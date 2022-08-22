using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        //Private vJE As SAPbobsCOM.JournalEntries
        //SAPbobsCOM.JournalVouchers cpte1;

        //SAPbobsCOM.JournalEntries_Lines linea1;
        //SAPbobsCOM.JournalEntries_Lines linea2;
        ServerConnection connection = new ServerConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intservertype = Convert.ToInt32(servertype.Text.Trim());
            int intlanguaje = Convert.ToInt32(languaje.Text.Trim());
            int inttrusted = Convert.ToInt32(trusted.Text.Trim());


            connection.Server = Server.Text.Trim();
            connection.CompanyDB = CompanyDB.Text.Trim();
            connection.DbUserName = DbUserName.Text.Trim();
            connection.DbPassword = DbPassword.Text.Trim();
            connection.UserName = UserName.Text.Trim();
            connection.Password = Password.Text.Trim();
            connection.LicenseServer = LicenseServer.Text.Trim();
            connection.SLDServer = SLDServer.Text.Trim();

            connection.intservertype = intservertype;
            connection.intlanguaje = intlanguaje;
            connection.inttrusted = inttrusted;

            res.Text = "";
            //string 
            // attempt connection; 0 = success
            if (connection.Connect() == 0)
            {
                res.Text += "Successfully connected to " + connection.GetCompany().CompanyName + "!";
                //connection.GetCompany().Disconnect();
            }
            else
            {
                res.Text += "Error " + connection.GetErrorCode() + ": " + connection.GetErrorMessage();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generar el asiento contable
            //cpte = new SAPbobsCOM.JournalEntries();
            //cpte = connection.(oJournalEntries)
            //SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
            SAPbobsCOM.JournalEntries cpte;
            cpte = connection.GetCompany().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);

            cpte.ReferenceDate = DateTime.Now;
            cpte.Memo = "glosa de pruebita";
            cpte.TaxDate = DateTime.Now;

            cpte.Lines.Add();
            cpte.Lines.SetCurrentLine(0);
            cpte.Lines.Debit = 67.25;
            cpte.Lines.Credit = 0;
            cpte.Lines.ShortName = "CL0003823";

            cpte.Lines.Add();
            cpte.Lines.SetCurrentLine(1);
            cpte.Lines.Debit = 0;
            cpte.Lines.Credit = 67.25;
            cpte.Lines.ShortName = "110103011";

            int r = cpte.Add();
            res.Text += "creo el comprobante nro. " + r + "!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //generar el asiento contable
            SAPbobsCOM.JournalEntries cpte;
            cpte = connection.GetCompany().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);

            cpte.ReferenceDate = DateTime.Now;
            cpte.Memo = "glosa de pruebita 2";
            cpte.TaxDate = DateTime.Now;

            cpte.Lines.Add();
            cpte.Lines.SetCurrentLine(0);
            cpte.Lines.Debit = 67.25;
            cpte.Lines.Credit = 0;
            cpte.Lines.ShortName = "CL0003823";

            cpte.Lines.Add();
            cpte.Lines.SetCurrentLine(1);
            cpte.Lines.Debit = 0;
            cpte.Lines.Credit = 67.25;
            cpte.Lines.ShortName = "110103011";

            int r = cpte.Add();
            res.Text += "creo el comprobante nro. " + r + "!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor = 54;
            SAPbobsCOM.JournalVouchers cpte1;
            cpte1 = connection.GetCompany().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalVouchers);

            //cpte1 = new SAPbobsCOM.JournalVouchers();
            cpte1.JournalEntries.ReferenceDate = DateTime.Now;
            cpte1.JournalEntries.Memo = "glosa de pruebita voucher";
            cpte1.JournalEntries.TaxDate = DateTime.Now;

            cpte1.JournalEntries.Lines.SetCurrentLine(0);
            cpte1.JournalEntries.Lines.Debit = valor;
            cpte1.JournalEntries.Lines.Credit = 0;
            cpte1.JournalEntries.Lines.ShortName = "810101002";
            cpte1.JournalEntries.Lines.Add();

            cpte1.JournalEntries.Lines.SetCurrentLine(1);
            cpte1.JournalEntries.Lines.Debit = 0;
            cpte1.JournalEntries.Lines.Credit = valor;
            cpte1.JournalEntries.Lines.ShortName = "310301001";
            cpte1.JournalEntries.Lines.Add();
            int r = cpte1.JournalEntries.Add();
            res.Text += "creo el comprobante nro. " + r + "!";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valor = 54;
            //cpte1 = new SAPbobsCOM.JournalVouchers();
            SAPbobsCOM.JournalVouchers cpte1;
            cpte1 = connection.GetCompany().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalVouchers);

            cpte1.JournalEntries.ReferenceDate = DateTime.Now;
            cpte1.JournalEntries.Memo = "glosa de pruebita voucher";
            cpte1.JournalEntries.TaxDate = DateTime.Now;

            //cpte1.JournalEntries.Lines.SetCurrentLine(0);
            cpte1.JournalEntries.Lines.Debit = valor;
            //cpte1.JournalEntries.Lines.Credit = 0;
            cpte1.JournalEntries.Lines.AccountCode = "810101002";
            cpte1.JournalEntries.Lines.ShortName = "810101002";
            cpte1.JournalEntries.Lines.Add();            

            //cpte1.JournalEntries.Lines.SetCurrentLine(1);
            //cpte1.JournalEntries.Lines.Debit = 0;
            cpte1.JournalEntries.Lines.Credit = valor;
            cpte1.JournalEntries.Lines.AccountCode = "310301001";
            cpte1.JournalEntries.Lines.ShortName = "310301001";
            cpte1.JournalEntries.Lines.Add();


            int r = cpte1.JournalEntries.Add();

            if (r == 0)
            {
                string msg = "";
                //int err = 0;
                connection.GetCompany().GetNewObjectCode(out msg);
                res.Text += "error ! " + " msg: " + msg;
            }
            else
            {
                string msg = "";
                int err = 0;
                connection.GetCompany().GetLastError(out err, out msg);
                res.Text += "error n. " + err + "! " + " msg: " + msg;
            }
            res.Text += "creo el comprobante nro. " + r + "!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //generar el asiento contable   ESTE ES EL CORRECTO
                //string res = "Crear asiento ...";
                res.Text = "";
                res.Text = "Crear asiento ..." + System.Environment.NewLine;

                SAPbobsCOM.JournalEntries cpte;
                cpte = connection.GetCompany().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);

                cpte.ReferenceDate = DateTime.Now;
                cpte.Memo = "glosa de pruebita de " + DateTime.Now;
                cpte.TaxDate = DateTime.Now;

                cpte.Lines.Add();
                cpte.Lines.SetCurrentLine(0);
                cpte.Lines.Debit = 100.25;
                cpte.Lines.Credit = 0;
                cpte.Lines.ShortName = "CL0003823";

                cpte.Lines.Add();
                cpte.Lines.SetCurrentLine(1);
                cpte.Lines.Debit = 0;
                cpte.Lines.Credit = 100.25;
                cpte.Lines.ShortName = "110103011";
                int r = cpte.Add();

                //connection.GetCompany().StartTransaction();

                //if (cpte.Add() == 0)
                //{
                //    string JENumber = string.Empty;
                //    connection.GetCompany().GetNewObjectCode(out JENumber);
                //    if (cpte.GetByKey(Convert.ToInt32(JENumber)))
                //    {
                //        int JournalID = cpte.Number;
                //        res.Text += "cpte ! " + JournalID;
                //        connection.GetCompany().EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit);
                //        return;
                //    }
                //    string msg = "";
                //    int err = 0;
                //    connection.GetCompany().GetLastError(out err, out msg);
                //    res.Text += "error n. " + err + "! " + " msg: " + msg;
                //}

                //oCompany.StartTransaction()
                //If (oSBOJournalEntry.Add() = 0) Then
                //    Dim JENumber As String = ""
                //    oCompany.GetNewObjectCode(JENumber)
                //    If oSBOJournalEntry.GetByKey(CInt(JENumber)) Then
                //        JournalID = oSBOJournalEntry.Number
                //        MsgBox(String.Format("Jounal Entry#{0} added.", JournalID))
                //        oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                //    End If
                //    oCompany.GetLastError(lErrCode, errMsg)
                //    MsgBox(errMsg)
                //End If

                if (r == 0)
                {
                    string msg = "";
                    int err = 0;
                    connection.GetCompany().GetNewObjectCode(out msg);
                    res.Text += "algo pasó! " + " msg: " + msg + System.Environment.NewLine; 

                    connection.GetCompany().GetLastError(out err, out msg);
                    res.Text += "error n. " + err + "! " + " msg: " + msg + System.Environment.NewLine; 
                }
                else
                {
                    res.Text += "asiento nro. " + r + System.Environment.NewLine; 
                }
      
            }
            catch (Exception ex)
            {

                res.Text += ex.Message + "!";
            }
        }
    }
}
