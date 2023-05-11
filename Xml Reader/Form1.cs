using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace XML_Reader_p
{
    public partial class Form1 : Form
    {
        public static SubaAcknowledgement suba;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear_Window();

            //Search file window
            OpenFileDialog XmlFiel = new OpenFileDialog();
            XmlFiel.Filter = "Office Files|*.xml;| All files (*.*)|*.*";

            //print the path from xml
            if (XmlFiel.ShowDialog() == DialogResult.OK)
                textBox1.Text = XmlFiel.FileName;

            //take the path and Serialize with the model and open and close the session
            Controller(XmlFiel.FileName);

            //get access in the data from classes
            SubaAcknowledgementReportContext DataReportContext = suba.ReportContext;
            SubaAcknowledgementReportContextReportedEntity DataReportContextReportedEntity = DataReportContext.ReportedEntity;
            SubaAcknowledgementStatistics DataStatistics = suba.Statistics;
            SubaAcknowledgementError[] DataError = suba.ErrorsFound;

            PrintSubaData(suba);

            PrintReportData(DataReportContextReportedEntity, DataReportContext);

            PrintStaticData(DataStatistics);

            PrintErrorData(DataError);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        public static void Controller(string XmlPath)
        {
            var filename = XmlPath;

            if (new FileInfo(XmlPath).Length == 0)
            {
                //Clear_Window();
                return;
            }

            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlSerializer x = new XmlSerializer(typeof(SubaAcknowledgement));
            SubaAcknowledgement g = (SubaAcknowledgement)x.Deserialize(fs);

            suba = g;
            fs.Close();
        }

        public void PrintSubaData(SubaAcknowledgement suba)
        {
            //print the data from xml to winform
            label15.Text = suba.ReferredSenderId;
            label21.Text = suba.ReferredIREF.ToString();
            label18.Text = suba.ReferredDateTimeReceived.ToString();
            label20.Text = suba.FileName.ToString();
            label19.Text = suba.Version.ToString();
            label17.Text = suba.Revision.ToString();
            label16.Text = suba.ValidationStatus.ToString();
            label13.Text = suba.AcceptanceStatus.ToString();
            if (suba.NCAreaction != null)
                label22.Text = suba.NCAreaction.ToString();
        }

        public void PrintReportData(SubaAcknowledgementReportContextReportedEntity DataReportContextReportedEntity, SubaAcknowledgementReportContext DataReportContext)
        {
            //add in the item the data from classes
            ListViewItem ItemReportContext = new ListViewItem(DataReportContextReportedEntity.EntityId.ToString());
            ItemReportContext.SubItems.Add(DataReportContextReportedEntity.EntityName.ToString());
            ItemReportContext.SubItems.Add(DataReportContext.Module.ToString());
            ItemReportContext.SubItems.Add(DataReportContext.ReferenceDate.ToString());

            //add item in the list 
            listView4.Items.Add(ItemReportContext);
        }

        public void PrintStaticData(SubaAcknowledgementStatistics DataStatistics)
        {
            //add in the item the data from classes
            ListViewItem ItemStatistics = new ListViewItem(DataStatistics.NumberOfValidItems.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfInformationItems.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfWarnings.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfNonRestrictiveErrors.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfErrors.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfFatalErrors.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.FilingIndicatorsFound.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfContextFound.ToString());
            ItemStatistics.SubItems.Add(DataStatistics.NumberOfFactsFound.ToString());

            //add item in the list 
            listView2.Items.Add(ItemStatistics);
        }
        
        public void PrintErrorData(SubaAcknowledgementError[] DataError)
        {
            if (suba.ErrorsFound == null)
                return ;
            
            int end = DataError.Count();
            /* int totalRows = suba.ErrorsFound.Count();*/
            for (int i = 0; i < end; i++)
            {
                //add in the item the data from classes
                ListViewItem ItemError = new ListViewItem();
                ItemError.SubItems.Add(i.ToString());
                ItemError.SubItems.Add(DataError[i].ErrorCode.ToString());
                ItemError.SubItems.Add(DataError[i].IsFatalError.ToString());
                ItemError.SubItems.Add(DataError[i].ErrorStatus.ToString());
                ItemError.SubItems.Add(DataError[i].ErrorSeverity.ToString());
                ItemError.SubItems.Add(DataError[i].Owner.ToString());
                ItemError.SubItems.Add(DataError[i].ShortDescription.ToString());
                ItemError.SubItems.Add(DataError[i].LongDescription.ToString());
                ItemError.SubItems.Add(DataError[i].FormulaExpression.ToString());
                //ItemError.SubItems.Add(DataError[i].Observation.ToString());

                //add item in the list 
                listView3.Items.Add(ItemError);
            }
            
        }

        public void Clear_Window()
        {
            label15.Text = "";
            label22.Text = "";
            label21.Text = "";
            label20.Text = "";
            label18.Text = "";
            label19.Text = "";
            label17.Text = "";
            label16.Text = "";
            label13.Text = "";
            listView4.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            
        }

    }
}
