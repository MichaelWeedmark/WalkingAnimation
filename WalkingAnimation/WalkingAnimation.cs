using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WalkingAnimation
{
    public partial class frmAnimation : Form
    {
        public frmAnimation()
        {
            InitializeComponent();
        }

        private void btnRunAnimation_Click(object sender, EventArgs e)
        {
            int loopcounter = 0;
            do
            {
                if (loopcounter == 0)
                {
                    this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk2;
                }
                else if (loopcounter == 1)

                    
                    {
                        this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk3;
                    }
                    else if (loopcounter == 2)

                       
                        {
                            this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk4;
                        }
                        else if (loopcounter == 3)

                           
                            {
                                this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk5;
                            }
                            else if (loopcounter == 4)

                               
                                {
                                    this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk6;
                                }
                                else if (loopcounter == 5)

                                    
                                    {
                                        this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk7;
                                    }
                                    else if (loopcounter == 6)

                                        
                                        {
                                            this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk8;
                                        }
                                        else if (loopcounter == 7)

                                           
                                            {
                                                this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk9;
                                            }
                                            else if (loopcounter == 8)

                                                
                                                {
                                                    this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk10;
                                                }
                                                else if (loopcounter == 9)

                                                   
                                                    {
                                                        this.picWalkingMan.Image = WalkingAnimation.Properties.Resources.walk1;
                                                    }

                 loopcounter = loopcounter + 1;

                    // pauses the animation
                    this.Refresh();
                    Thread.Sleep(100);

                } while (loopcounter < 10);
            }
    }
}
