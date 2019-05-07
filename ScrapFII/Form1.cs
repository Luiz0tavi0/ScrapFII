using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HtmlAgilityPack;



namespace ScrapFII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string url = "https://fiis.com.br/";

            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument html = web.Load(url + "lista-por-codigo/");

            List <FII> listaFII = new List<FII>();

            foreach (HtmlNode row in html.DocumentNode.SelectNodes("//div[@class = 'entry-content']//table//tbody//tr//td[2]//a"));
            {             
                
                //Console.WriteLine(row.Attributes["title"].Value + "-" + row.InnerText);
                //listaFII.Add(new FI(row.Attributes["title"].Value, row.Attributes["title"].Value + " - " + row.InnerText));
            }
            cmbListaFIIS.DataSource = listaFII;
            cmbListaFIIS.DisplayMember = "nome";
            cmbListaFIIS.ValueMember= "sigla";
        }

        private void cmbListaFIIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cmbListaFIIS.SelectedValue.ToString());
        }

        /*public HtmlAgilityPack.HtmlDocument CapturaHtml(string link)
        {

            return ;
        }*/
    }
    

}

