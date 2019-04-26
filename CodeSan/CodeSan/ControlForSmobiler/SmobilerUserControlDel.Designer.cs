using System;
using Smobiler . Core;
namespace CodeSan . ControlForSmobiler
{
    partial class SmobilerUserControlDel : Smobiler . Core . Controls . MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.btnDel = new Smobiler.Core.Controls.Button();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.BorderRadius = 0;
            this.btnDel.FontSize = 16F;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 60);
            this.btnDel.Text = "删除";
            // 
            // SmobilerUserControlDel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDel});
            this.Name = "SmobilerUserControlDel";

        }
        #endregion

        private Smobiler . Core . Controls . Button btnDel;
    }
}