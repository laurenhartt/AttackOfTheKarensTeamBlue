using KarenLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Runtime;

namespace AttackOfTheKarens
{
    public partial class FrmMall : Form
    {
        // consts
        private const int PANEL_PADDING = 10;
        private const int FORM_PADDING = 60;
        private const int CELL_SIZE = 64;
        private readonly Random rand = new Random();
        private readonly Color[] colors = new Color[5] { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Yellow };

        // other privates
        private SoundPlayer player;
        private PictureBox picOwner;
        private PictureBox picBoss;
        private PictureBox picManager;
        private int xOwner;
        private int yOwner;
        //private int xBoss;
        //private int yBoss;
        private int xManager;
        private int yManager;
        private char[][] map;
        private DateTime scoreTimer;
        private DateTime scoreTimer2;
        private List<Store> Karenstores;
        private List<Store> ManagerStores;
        private int rate = 10;

        // ctor
        public FrmMall()
        {
            Game.openForms.Add(this);
            InitializeComponent();
        }

        // functions
        private void LoadMap()
        {
            string fileContents = File.ReadAllText("data/mall.txt");
            string[] lines = fileContents.Split(Environment.NewLine);
            map = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                map[i] = lines[i].ToCharArray();
            }
        }



        private PictureBox CreatePic(Image img, int top, int left)
        {
            return new PictureBox()
            {
                Image = img,
                Top = top,
                Left = left,
                Width = CELL_SIZE,
                Height = CELL_SIZE,
            };
        }

        private PictureBox CreateWall(Color color, Image img, int top, int left)
        {
            PictureBox picWall = CreatePic(img, top, left);
            picWall.Image.Tint(color);
            return picWall;
        }

        private void GenerateMall(Color color)
        {
            panMall.Controls.Clear();
            int top = 0;
            int left = 0;


            PictureBox pic = null;
            PictureBox picBoss = null;
            foreach (char[] array in map)
            {
                foreach (char c in array)
                {
                    switch (c)
                    {
                        case 'K':
                        case 'B':
                            picBoss = CreatePic(Properties.Resources.boss, top, left);
                            pic = CreatePic(Properties.Resources.karen, top, left);
                            Store s = new Store(new Karen(pic)
                            {
                                Row = top / CELL_SIZE,
                                Col = left / CELL_SIZE,
                            }, new Boss(picBoss)
                            {
                                Row = top / CELL_SIZE,
                                Col = left / CELL_SIZE,
                            });
                            Karenstores.Add(s);
                            break;
                        /*case 'B':
                          pic = CreatePic(Properties.Resources.boss, top, left);
                          xBoss = left / CELL_SIZE;
                          yBoss = top / CELL_SIZE;
                          break;
                        */
                        case 'M':
                            picManager = CreatePic(Properties.Resources.storemanager, top, left);
                            xManager = top / CELL_SIZE;
                            yManager = left / CELL_SIZE;
                            break;
                        case 'o':
                            picOwner = CreatePic(Properties.Resources.owner, top, left);
                            xOwner = left / CELL_SIZE;
                            yOwner = top / CELL_SIZE;
                            panMall.Controls.Add(picOwner);
                            break;
                        case 'w': pic = CreatePic(Properties.Resources.water, top, left); break;
                        case '-': pic = CreateWall(color, Properties.Resources.hline, top, left); break;
                        case '|': pic = CreateWall(color, Properties.Resources.vline, top, left); break;
                        case 'a': pic = CreateWall(color, Properties.Resources.a, top, left); break;
                        case 'b': pic = CreateWall(color, Properties.Resources.b, top, left); break;
                        case 'c': pic = CreateWall(color, Properties.Resources.c, top, left); break;
                        case 'd': pic = CreateWall(color, Properties.Resources.d, top, left); break;
                        case 'e': pic = CreateWall(color, Properties.Resources.e, top, left); break;
                        case 'f': pic = CreateWall(color, Properties.Resources.f, top, left); break;
                        case 'g': pic = CreateWall(color, Properties.Resources.g, top, left); break;
                        case 'h': pic = CreateWall(color, Properties.Resources.h, top, left); break;
                    }
                    left += CELL_SIZE;
                    if (pic != null)
                    {
                        panMall.Controls.Add(pic);
                    }
                    if (picBoss != null)
                    {
                        panMall.Controls.Add(picBoss);
                    }
                    //if (picManager != null)
                    //{
                     //   panMall.Controls.Add(picManager);
                    //}
                }
                left = 0;
                top += CELL_SIZE;
            }

            picOwner.BringToFront();
            panMall.Width = CELL_SIZE * map[0].Length + PANEL_PADDING;
            panMall.Height = CELL_SIZE * map.Length + PANEL_PADDING;
            this.Width = panMall.Width + FORM_PADDING + 75;
            this.Height = panMall.Height + FORM_PADDING;
            lblMoneySaved.Left = this.Width - lblMoneySaved.Width - 10;
            //lblMoneySavedLabel.Left = this.Width - lblMoneySavedLabel.Width - 10;
            //lblMoneySavedLabel.Top = 0;
            lblMoneySaved.Top = 0;
        }

        private void FrmMall_Load(object sender, EventArgs e)
        {
            Karenstores = new List<Store>();
            ManagerStores = new List<Store>();
            LoadMap();
            GenerateMall(colors[rand.Next(colors.Length)]);
            tmrKarenSpawner.Interval = rand.Next(1000, 5000);
            tmrKarenSpawner.Enabled = true;
            tmrBossSpawner.Interval = rand.Next(100, 500);
            tmrBossSpawner.Enabled = true;
            player = new SoundPlayer();
            player.SoundLocation = "data/mall music.wav";
            player.PlayLooping();
            scoreTimer = DateTime.Now;
        }

        private bool IsInBounds(int newRow, int newCol)
        {
            return (newRow >= 0 && newRow < map.Length && newCol >= 0 && newCol < map[0].Length);
        }

        private bool IsWalkable(int newRow, int newCol)
        {
            char[] walkableTiles = new char[] { ' ', 'o', 'K', 'B', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'L' };
            if (Karenstores != null && Karenstores.Count > 0)
            {
                foreach (Store store in Karenstores)
                {
                    if ((store.karen.IsPresent || store.boss.IsPresent) && store.containsOwner && (map[newRow][newCol] == 'K'))
                    {
                        return false;
                    }
                }
            }
            return walkableTiles.Contains(map[newRow][newCol]);
        }

        private bool CanMove(Direction dir, out int newRow, out int newCol)
        {
            newRow = yOwner;
            newCol = xOwner;
            switch (dir)
            {
                case Direction.UP: newRow--; break;
                case Direction.DOWN: newRow++; break;
                case Direction.LEFT: newCol--; break;
                case Direction.RIGHT: newCol++; break;
            }
            return (IsInBounds(newRow, newCol) && IsWalkable(newRow, newCol));
        }

        private new void Move(Direction dir)
        {
            if (CanMove(dir, out int newRow, out int newCol))
            {
                yOwner = newRow;
                xOwner = newCol;
                picOwner.Visible = false;
                picOwner.Top = yOwner * CELL_SIZE;
                picOwner.Left = xOwner * CELL_SIZE;
                char mapTile = map[newRow][newCol];
                picOwner.Visible = true;
                switch (mapTile)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        Karenstores[int.Parse(mapTile.ToString())].OwnerWalksIn();
                        break;
                    case 'L':
                        foreach (Store store in Karenstores)
                        {
                            store.ResetOwner();
                        }
                        break;
                }
            }
        }

        private void FrmMall_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: Move(Direction.UP); break;
                case Keys.Down: Move(Direction.DOWN); break;
                case Keys.Left: Move(Direction.LEFT); break;
                case Keys.Right: Move(Direction.RIGHT); break;
            }
        }
        private void tmrKarenSpawner_Tick(object sender, EventArgs e)
        {
            Store s = Karenstores[rand.Next(Karenstores.Count)];
            if(!s.boss.IsPresent) s.ActivateTheKaren();
        }

        private void tmrBossSpawner_Tick(object sender, EventArgs e)
        {
            if (Game.Score % 1000 < 25 && Game.Score > 1000)
            {
                Store s = Karenstores[rand.Next(Karenstores.Count)];
                s.BossTime();
            }
        }

        private void FrmMall_FormClosed(object sender, FormClosedEventArgs e)
        {
            Game.openForms.Remove(this);
            Game.CloseAll();
        }

        private void tmrUpdateKarens_Tick(object sender, EventArgs e)
        {
            if (Karenstores != null && Karenstores.Count > 0)
            {
                foreach (Store store in Karenstores)
                {
                    store.Update();
                }
            }
        }

        private void tmrUpdateBoss_Tick(object sender, EventArgs e)
        {
            if (Karenstores != null && Karenstores.Count > 0)
            {
                foreach (Store store in Karenstores)
                {
                    store.BUpdate();
                }
            }
        }

//        private void tmrMoveOwner_Tick(object sender, EventArgs e) {
//          Direction dir = (Direction)rand.Next(4);
//          Move(dir);
//        }

        private void tmrUpdateGame_Tick(object sender, EventArgs e)
        {
            

            lblMoneySaved.Text = Game.Score.ToString("$ #,##0.00");
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            //player?.Stop();
            ItemStore itemstore = new ItemStore();
            itemstore.Show();
            //this.Hide();
            itemstore.rateUpgradeEvent += itemstore_rateClick;

        }

        private void gameScore_Tick(object sender, EventArgs e)
        {
            float newScore;
            int count = 0;
            TimeSpan interval = new TimeSpan();
            scoreTimer2 = DateTime.Now;
            interval = scoreTimer2.Subtract(scoreTimer);
            scoreTimer = scoreTimer2;
            double newTime = interval.TotalSeconds;
            foreach(Store s in Karenstores)
            {
                if (s.karen.IsPresent) count += 1;
                if (s.boss.IsPresent) count += 3;
            }
            if (count == 0)  newScore = (float)(rate * newTime);
       
            else newScore = (float)((rate / count) * newTime); 
            Game.AddToScore(newScore);
        }

        public void ManagerSpawn(object sender, EventArgs e)
        {
            Store s = ManagerStores[rand.Next(ManagerStores.Count)];
            s.DeployManager();
        }
        private void itemstore_rateClick(object sender, EventArgs e)
        {
            rate += 1;
        }
    }
}


