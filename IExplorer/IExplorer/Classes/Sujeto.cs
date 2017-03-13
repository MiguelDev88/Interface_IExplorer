using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer
{
    class Sujeto : TreeView
    {
        public List<Observador> observers { get; set; }

        public void attach(Observador observer) {
            if (observers == null)
                observers = new List<Observador>();
            observers.Add(observer);
        }

        public void detach(Observador observer) {
            observers.Remove(observer);
        }

        public void notify(Phone phone) {

            foreach (Observador o in observers)
            {
                o.update(phone);
            }

        }

        public void newNode(Phone phone)
        {
            TreeNode root = new TreeNode(phone.name);
            root.ImageIndex = 5; root.SelectedImageIndex = 5;

            TreeNode media = new TreeNode("Media");
            media.ImageIndex = 6; media.SelectedImageIndex = 6;
            root.Nodes.Add(media);

            TreeNode apps = new TreeNode("Apps");
            apps.ImageIndex = 0; apps.SelectedImageIndex = 0;
            root.Nodes.Add(apps);

            TreeNode backups = new TreeNode("Backups");
            backups.ImageIndex = 2; backups.SelectedImageIndex = 2;
            root.Nodes.Add(backups);

            TreeNode mediaLibrary = new TreeNode("Media Library");
            mediaLibrary.ImageIndex = 1; mediaLibrary.SelectedImageIndex = 1;
            root.Nodes.Add(mediaLibrary);

            TreeNode photos = new TreeNode("Photos");
            photos.ImageIndex = 4; photos.SelectedImageIndex = 4;
            root.Nodes.Add(photos);

            TreeNode bookmarks = new TreeNode("Bookmarks");
            bookmarks.ImageIndex = 3; bookmarks.SelectedImageIndex = 3;
            root.Nodes.Add(bookmarks);

            this.Nodes.Add(root);

        }

    }
}
