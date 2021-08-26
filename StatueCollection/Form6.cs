using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatueCollection
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void picSideshow_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink1();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        } //sideshow link
        private void VisitLink1()
        {
            System.Diagnostics.Process.Start("https://www.sideshow.com/");
        }
        private void picPrime_Click(object sender, EventArgs e) //prime 1 link
        {
            try
            {
                VisitLink2();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink2()
        {
            System.Diagnostics.Process.Start("https://www.prime1studio.com/");
        }
        private void picXM_Click(object sender, EventArgs e) //xm link
        {
            try
            {
                VisitLink3();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink3()
        {
            System.Diagnostics.Process.Start("https://www.xm-studios.com/");
        }
        private void picIron_Click(object sender, EventArgs e) //iron studios link
        {
            try
            {
                VisitLink4();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink4()
        {
            System.Diagnostics.Process.Start("https://ironstudios.com/");
        }
        private void picPCS_Click(object sender, EventArgs e) //PCS link
        {
            try
            {
                VisitLink5();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink5()
        {
            System.Diagnostics.Process.Start("https://www.collectpcs.com/");
        }
        private void picTweeter_Click(object sender, EventArgs e) //Tweeterhead link
        {
            try
            {
                VisitLink6();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink6()
        {
            System.Diagnostics.Process.Start("https://tweeterhead.com/");
        }
        private void picQueen_Click(object sender, EventArgs e) //Queen Studios link
        {
            try
            {
                VisitLink7();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink7()
        {
            System.Diagnostics.Process.Start("https://queenstudios.shop/");
        }

        private void picBeast_Click(object sender, EventArgs e) //Beast Kingdom link
        {
            try
            {
                VisitLink8();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink8()
        {
            System.Diagnostics.Process.Start("https://beast-kingdom.us/");
        }

        private void picBigBad_Click(object sender, EventArgs e) //BigBad ToyStore link
        {
            try
            {
                VisitLink9();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink9()
        {
            System.Diagnostics.Process.Start("https://www.bigbadtoystore.com/");
        }

        private void picFirstFour_Click(object sender, EventArgs e) //FirstFourFigures link
        {
            try
            {
                VisitLink10();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink10()
        {
            System.Diagnostics.Process.Start("https://www.first4figures.com/");
        }

        private void picHCG_Click(object sender, EventArgs e) //HCG Collectibles link
        {
            try
            {
                VisitLink11();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink11()
        {
            System.Diagnostics.Process.Start("https://www.hollywood-collectibles.com/store/");
        }

        private void picPure_Click(object sender, EventArgs e) //Pure Arts link
        {
            try
            {
                VisitLink12();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink12()
        {
            System.Diagnostics.Process.Start("https://www.purearts.com/");
        }

        private void picWeta_Click(object sender, EventArgs e) //Weta link
        {
            try
            {
                VisitLink13();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink13()
        {
            System.Diagnostics.Process.Start("https://www.wetanz.com/");
        }

        private void picBlitz_Click(object sender, EventArgs e) //Blitzway
        {
            try
            {
                VisitLink14();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink14()
        {
            System.Diagnostics.Process.Start("https://blitzway.com/");
        }

        private void picSecret_Click(object sender, EventArgs e) //Secret Compass link
        {
            try
            {
                VisitLink15();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink15()
        {
            System.Diagnostics.Process.Start("https://www.secretcompassonline.com/");
        }

        private void picSpec_Click(object sender, EventArgs e) //Spec Fiction link
        {
            try
            {
                VisitLink16();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink16()
        {
            System.Diagnostics.Process.Start("https://www.specfictionshop.com/");
        }

        private void picStatueDepot_Click(object sender, EventArgs e) //Statue Depot link
        {
            try
            {
                VisitLink17();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink17()
        {
            System.Diagnostics.Process.Start("https://statuedepot.com/");
        }

        private void picDcDirect_Click(object sender, EventArgs e) //DC Direct Link
        {
            try
            {
                VisitLink18();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink18()
        {
            System.Diagnostics.Process.Start("https://www.dccomics.com/collectibles");
        }

        private void picComicConcepts_Click(object sender, EventArgs e) //Comic Concepts link
        {
            try
            {
                VisitLink19();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink19()
        {
            System.Diagnostics.Process.Start("https://comic-concepts.com/en");
        }
    }
    
}
