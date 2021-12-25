using System;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace lb6
{
    public partial class MainView : Form
    {
        private Thread activeThread;
        public delegate void ModeHandler();
        public event ModeHandler onChanged;
        static public Mode activeMode = Mode.Stay;
       
        private const int
            buyMoney = -100, produceMoney = -10, sellMoney = 400, buyMaterial = 2, produceMaterial = -1,
            buyTime = 5000, sellTime = 5000,
            produceProduct = 1, sellProduct = -1, produceTime = 10000; 
           

        private void nProduct_ValueChanged(object sender, EventArgs e)
        {
            Factory.Product = (int)nProduct.Value;
        }

        private void nMaterial_ValueChanged(object sender, EventArgs e)
        {
            Factory.Material = (int)nMaterial.Value;
        }

        private void nMoney_ValueChanged(object sender, EventArgs e)
        {
            Factory.Money = (int)nMoney.Value;
        }

        public MainView()
        {
            InitializeComponent();
            pbProgress.Minimum = 0;
            pbProgress.Step = 1;
            onChanged += setNextMode;
            onChanged += UpdateData;
            onChanged += CreateReport;
            Factory.Product = 10;
            Factory.Material = 10;
            Factory.Money = 1000;
        }

        private void UpdateData()
        {
            if (nMaterial.InvokeRequired)
            {
                Action update = delegate { UpdateData(); };
                nMaterial.Invoke(update);
            }
            else
            {
                nMaterial.Value = Factory.Material;
            }

            if (nMoney.InvokeRequired)
            {
                Action update = delegate { UpdateData(); };
                nMoney.Invoke(update);
            }
            else
            {
                nMoney.Value = Factory.Money;
            }

            if (nProduct.InvokeRequired)
            {
                Action update = delegate { UpdateData(); };
                nProduct.Invoke(update);
            }
            else
            {
                nProduct.Value = Factory.Product;
            }

            if (pbProgress.InvokeRequired)
            {
                Action update = delegate { UpdateData(); };
                pbProgress.Invoke(update);
            }
            else
            {
                pbProgress.Value = 0;
            }
        }
        private void PerformSec(int time)
        {
            int stepsAmount = time / 1000;
            for (int i = 0; i < stepsAmount; i++)
            {
                ProgressBarStep();
                Thread.Sleep(1000);
            }
        }
        private void ProgressBarStep()
        {
            if (pbProgress.InvokeRequired)
            {
                Action update = delegate { ProgressBarStep(); };
                pbProgress.Invoke(update);
            }
            else
            {
                pbProgress.PerformStep();
            }
        }

        private void CreateReport()
        {
            XmlDocument xReport = new XmlDocument();
            xReport.Load("report.xml");
            XmlElement xRoot = xReport.DocumentElement;

            XmlElement timeElem = xReport.CreateElement("d" + DateTime.Now.ToString().Replace(' ', '-').Replace('/', '-').Replace(':', '-'));
            XmlElement moneyElem = xReport.CreateElement ("money");
            XmlElement matElem = xReport.CreateElement("material");
            XmlElement prodElem = xReport.CreateElement("product");

            XmlText moneyText = xReport.CreateTextNode(Factory.Money.ToString());
            XmlText matText = xReport.CreateTextNode(Factory.Material.ToString());
            XmlText prodText = xReport.CreateTextNode(Factory.Product.ToString());

            moneyElem.AppendChild(moneyText);
            matElem.AppendChild(matText);
            prodElem.AppendChild(prodText);
            timeElem.AppendChild(moneyElem);
            timeElem.AppendChild(matElem);
            timeElem.AppendChild(prodElem);
            xRoot.AppendChild(timeElem);
            xReport.Save("report.xml");
        }


        private void setNextMode()
        {
            if (activeThread != null && activeThread.IsAlive)
            {
                activeThread.Abort();
            }
                
            switch (activeMode)
            {
                case Mode.Buy:
                    activeThread = new Thread(buy);
                    activeThread.IsBackground = true;
                    pbProgress.Maximum = buyTime / 1000;
                    break;
                case Mode.Produce:
                    activeThread = new Thread(produce);
                    activeThread.IsBackground = true;
                    pbProgress.Maximum = produceTime / 1000;
                    break;
                case Mode.Sell:
                    activeThread = new Thread(sell);
                    activeThread.IsBackground = true;
                    pbProgress.Maximum = sellTime / 1000;
                    break;
                case Mode.Stay:
                    activeThread = new Thread(stay);
                    activeThread.IsBackground = true;
                    break;
                default:
                    break;
            }
            activeThread?.Start();
        }

        private void buy()
        {
            while (true) 
            {
                PerformSec(buyTime);
                Factory.Money += buyMoney;
                Factory.Material += buyMaterial;
                UpdateData();
            }            
        }

        private void produce()
        {
            while (true)
            {
                PerformSec(produceTime);
                Factory.Money += produceMoney;
                Factory.Material += produceMaterial;
                Factory.Product += produceProduct;
                UpdateData();
            }  
        }

        private void sell()
        { 
            while (true)
            {
                PerformSec(sellTime);
                Factory.Money += sellMoney;
                Factory.Product += sellProduct;
                UpdateData();
            }
        }
        private void stay()
        {
            while (true);
        }

        private void rbModeBuy_CheckedChanged(object sender, EventArgs e)
        {
            activeMode = Mode.Buy;
            if(rbModeBuy.Checked)
            {
                onChanged?.Invoke(); 
            }
                
                      
        }

        private void rbModeProduce_CheckedChanged(object sender, EventArgs e)
        {
            activeMode = Mode.Produce;
            
            if (rbModeProduce.Checked) 
            {
                onChanged?.Invoke();
            }
        }

        private void rbModeSell_CheckedChanged(object sender, EventArgs e)
        {
            activeMode = Mode.Sell;
            if (rbModeSell.Checked)
            {
                onChanged?.Invoke();
            }
               
        }

        private void rbStay_CheckedChanged(object sender, EventArgs e)
        {
            activeMode = Mode.Stay;
            if (rbModeStay.Checked)
            {
                onChanged?.Invoke();
            }     
        }
    }
      public enum Mode
        {
            Buy,
            Produce,
            Sell,
            Stay
        }
}
