using System.Windows.Forms;

namespace KarenLogic {
    public class StoreManager
    {
        /// <summary>
        /// The pixel location of the row StoreManager is on
        /// </summary>
        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsPresent { get; set; }

        /// <summary>
        /// This is the image of the StoreManager
        /// </summary>
        public PictureBox pic;
        

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pic">The PictureBox container for the StoreManager</param>
        public StoreManager(PictureBox pic) {
          this.pic = pic;
          this.pic.Visible = false;
          this.IsPresent = false;
          this.pic.BringToFront();
        }

        public void Appear()
        {
            //this.Health = 5;
            this.pic.Visible = true;
            this.IsPresent = true;
            this.pic.BringToFront();

        }
    }
}
