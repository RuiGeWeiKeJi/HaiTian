using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormBaseBack : SmobilerFormBase
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 28);
            this . panel1 . Touchable = true;
            this . panel1 . TouchOpacity = 100;
            this .panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(14, 0);
            this.image1.Name = "image1";
            this.image1.ResourceID = "back";
            this.image1.Size = new System.Drawing.Size(45, 28);
            // 
            // SmobilerFormBaseBack
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "SmobilerFormBaseBack";

        }
        #endregion

        private Smobiler . Core . Controls . Panel panel1;
        private Smobiler . Core . Controls . Image image1;
    }
}