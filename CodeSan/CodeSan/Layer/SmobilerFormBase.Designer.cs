using Smobiler . Core;

namespace CodeSan
{
    partial class SmobilerFormBase : Smobiler . Core . Controls . MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Location = new System.Drawing.Point(50, 100);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 30);
            // 
            // SmobilerFormBase
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1});
            this.Name = "SmobilerFormBase";

        }
        #endregion

        private Smobiler . Core . Controls . Title title1;
    }
}