using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client.CostumControls
{
   public  class RoundedTextBox : MetroTextBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.DrawRectangle(Pens.White, 0, 0, this.Width-2, this.Height-1);
           
        }
    }
}
