using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDistributionService
{
    public partial class MDI : Form
    {

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            InitializeSomeObjects();
        }

        private void storePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentScreen(new StorePage(), "Store Page");
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentScreen(new AddGame(), "Add Game");
        }

        private void seeOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentScreen(new SeeOrders(), "See Orders");
        }

        private void addDLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentScreen(new AddDLC(), "Add DLC");
        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetCurrentScreen(new AddPublisher(), "Add Publisher");
        }


        private void SetCurrentScreen(Form nextScreen, string pageTitle)
        {       
            nextScreen.MdiParent = this;
            nextScreen.Dock = DockStyle.Fill;
            this.ClientSize = nextScreen.Size;
            this.Text = pageTitle;
            nextScreen.Show();
        }

        #region Needless Setup for Games, Publishers and DLCs
        void InitializeSomeObjects()
        {
            StorePage.publishers.Add(new Publisher("Super Giant Games"));
            StorePage.publishers.Add(new Publisher("Ubisoft"));
            StorePage.publishers.Add(new Publisher("EA"));
            StorePage.publishers.Add(new Publisher("CD Project Red"));
            StorePage.publishers.Add(new Publisher("Rockstar Games"));
            StorePage.publishers.Add(new Publisher("Square Enix"));

            StorePage.dlcs.Add(new DLC("Super Giant DLC", 2.4));//0
            StorePage.dlcs.Add(new DLC("Hades OST", 5));//1
            StorePage.dlcs.Add(new DLC("Hades Artbook", 7));//2

            StorePage.dlcs.Add(new DLC("Super Giant DLC", 1.4));//3
            StorePage.dlcs.Add(new DLC("Bastion OST", 2));//4
            StorePage.dlcs.Add(new DLC("Bastion Artbook", 5));//5

            StorePage.dlcs.Add(new DLC("Super Giant DLC", 2.3));//6
            StorePage.dlcs.Add(new DLC("Transistor OST", 1));//7
            StorePage.dlcs.Add(new DLC("Transistor Artbook", 6));//8

            StorePage.dlcs.Add(new DLC("Premium Content 1", 2.3));//9
            StorePage.dlcs.Add(new DLC("Premium Content 2", 1));//10
            StorePage.dlcs.Add(new DLC("Premium Content 3", 6));//11
            StorePage.dlcs.Add(new DLC("Premium Content 4", 2.3));//12
            StorePage.dlcs.Add(new DLC("Premium Content 5", 4));//13
            StorePage.dlcs.Add(new DLC("Premium Content 6", 7));//14

            StorePage.dlcs.Add(new DLC("Give me money 1", 20.3));//15
            StorePage.dlcs.Add(new DLC("Give me money 2", 10));//16
            StorePage.dlcs.Add(new DLC("Give me money 3", 60));//17

            StorePage.dlcs.Add(new DLC("Extend Pack 1", 15));//18
            StorePage.dlcs.Add(new DLC("Extend Pack 2", 20));//19
            StorePage.dlcs.Add(new DLC("Extend Pack 3", 25));//20
            StorePage.dlcs.Add(new DLC("Original Soundtrack", 5));//21
            StorePage.dlcs.Add(new DLC("Digital Artbook", 10));//22
            StorePage.dlcs.Add(new DLC("Deluxe Story Pack", 30));//23

            StorePage.dlcs.Add(new DLC("Online Edition", 15));//24
            StorePage.dlcs.Add(new DLC("10000 Credits", 100));//25
            StorePage.dlcs.Add(new DLC("Expantion Pass", 60));//26

            StorePage.dlcs.Add(new DLC("FFXII OST", 15));//27
            StorePage.dlcs.Add(new DLC("FFXII Digital Art book", 10));//28

            StorePage.dlcs.Add(new DLC("FFXV Digital Art book", 20));//29
            StorePage.dlcs.Add(new DLC("Episode Ardyn", 30));//30
            StorePage.dlcs.Add(new DLC("Episode Gladius", 15));//31
            StorePage.dlcs.Add(new DLC("Episode Ignis", 15));//32
            StorePage.dlcs.Add(new DLC("Episode Prompto", 15));//33
            StorePage.dlcs.Add(new DLC("Episode Noctis", 12));//34

            StorePage.dlcs.Add(new DLC("FFXV Digital Art book", 25));//35
            StorePage.dlcs.Add(new DLC("Episode 1", 6));//36
            StorePage.dlcs.Add(new DLC("Episode 2", 1));//37
            StorePage.dlcs.Add(new DLC("Episode 3", 6));//38
            StorePage.dlcs.Add(new DLC("Episode 4", 6));//39
            StorePage.dlcs.Add(new DLC("Episode 5", 1));//40
            StorePage.dlcs.Add(new DLC("Episode 6", 6));//41
            StorePage.dlcs.Add(new DLC("Episode 7", 6));//42
            StorePage.dlcs.Add(new DLC("Episode 8", 1));//43
            StorePage.dlcs.Add(new DLC("Episode 9", 6));//44
            StorePage.dlcs.Add(new DLC("Behind the Scenes", 6));//45

            StorePage.games.Add(new Game("Hades", 30, StorePage.publishers[0], new DateTime(2019, 05, 17)));
            StorePage.games[0].DLCs.Add(StorePage.dlcs[0]);
            StorePage.games[0].DLCs.Add(StorePage.dlcs[1]);
            StorePage.games[0].DLCs.Add(StorePage.dlcs[2]);

            StorePage.games.Add(new Game("Bastion", 15, StorePage.publishers[0], new DateTime(2014, 12, 15)));
            StorePage.games[1].DLCs.Add(StorePage.dlcs[3]);
            StorePage.games[1].DLCs.Add(StorePage.dlcs[4]);
            StorePage.games[1].DLCs.Add(StorePage.dlcs[5]);

            StorePage.games.Add(new Game("Transistor", 20, StorePage.publishers[0], new DateTime(209, 08, 05)));
            StorePage.games[2].DLCs.Add(StorePage.dlcs[6]);
            StorePage.games[2].DLCs.Add(StorePage.dlcs[7]);
            StorePage.games[2].DLCs.Add(StorePage.dlcs[8]);

            StorePage.publishers[0].Games.Add(StorePage.games[0]);
            StorePage.publishers[0].Games.Add(StorePage.games[1]);
            StorePage.publishers[0].Games.Add(StorePage.games[2]);


            StorePage.games.Add(new Game("Assasin's Creed Oyssey", 60, StorePage.publishers[1], new DateTime(2018, 10, 30)));
            StorePage.games[3].DLCs.Add(StorePage.dlcs[9]);
            StorePage.games[3].DLCs.Add(StorePage.dlcs[10]);
            StorePage.games[3].DLCs.Add(StorePage.dlcs[11]);
            StorePage.games[3].DLCs.Add(StorePage.dlcs[12]);
            StorePage.games[3].DLCs.Add(StorePage.dlcs[13]);
            StorePage.games[3].DLCs.Add(StorePage.dlcs[14]);

            StorePage.games.Add(new Game("Rayman", 10, StorePage.publishers[1], new DateTime(2002, 06, 18)));
            StorePage.games[4].DLCs.Add(StorePage.dlcs[9]);
            StorePage.games[4].DLCs.Add(StorePage.dlcs[10]);
            StorePage.games[4].DLCs.Add(StorePage.dlcs[11]);
            StorePage.games[4].DLCs.Add(StorePage.dlcs[12]);
            StorePage.games[4].DLCs.Add(StorePage.dlcs[13]);
            StorePage.games[4].DLCs.Add(StorePage.dlcs[14]);

            StorePage.games.Add(new Game("Far Cry 5", 45, StorePage.publishers[1], new DateTime(2018, 07, 07)));
            StorePage.games[5].DLCs.Add(StorePage.dlcs[9]);
            StorePage.games[5].DLCs.Add(StorePage.dlcs[10]);
            StorePage.games[5].DLCs.Add(StorePage.dlcs[11]);
            StorePage.games[5].DLCs.Add(StorePage.dlcs[12]);
            StorePage.games[5].DLCs.Add(StorePage.dlcs[13]);
            StorePage.games[5].DLCs.Add(StorePage.dlcs[14]);

            StorePage.publishers[1].Games.Add(StorePage.games[3]);
            StorePage.publishers[1].Games.Add(StorePage.games[4]);
            StorePage.publishers[1].Games.Add(StorePage.games[5]);

            StorePage.games.Add(new Game("It Takes Two", 30, StorePage.publishers[2], new DateTime(2019, 05, 17)));
            StorePage.games[6].DLCs.Add(StorePage.dlcs[15]);
            StorePage.games[6].DLCs.Add(StorePage.dlcs[16]);
            StorePage.games[6].DLCs.Add(StorePage.dlcs[17]);

            StorePage.games.Add(new Game("Fifa 2022", 60, StorePage.publishers[2], new DateTime(2021, 07, 12)));
            StorePage.games[7].DLCs.Add(StorePage.dlcs[15]);
            StorePage.games[7].DLCs.Add(StorePage.dlcs[16]);
            StorePage.games[7].DLCs.Add(StorePage.dlcs[17]);

            StorePage.games.Add(new Game("Battlefield 1", 35, StorePage.publishers[2], new DateTime(2019, 05, 17)));
            StorePage.games[8].DLCs.Add(StorePage.dlcs[15]);
            StorePage.games[8].DLCs.Add(StorePage.dlcs[16]);
            StorePage.games[8].DLCs.Add(StorePage.dlcs[17]);

            StorePage.publishers[2].Games.Add(StorePage.games[6]);
            StorePage.publishers[2].Games.Add(StorePage.games[7]);
            StorePage.publishers[2].Games.Add(StorePage.games[8]);

            StorePage.games.Add(new Game("Witcher 1", 5, StorePage.publishers[3], new DateTime(2004, 05, 17)));
            StorePage.games[9].DLCs.Add(StorePage.dlcs[18]);
            StorePage.games[9].DLCs.Add(StorePage.dlcs[19]);
            StorePage.games[9].DLCs.Add(StorePage.dlcs[20]);
            StorePage.games[9].DLCs.Add(StorePage.dlcs[21]);
            StorePage.games[9].DLCs.Add(StorePage.dlcs[22]);
            StorePage.games[9].DLCs.Add(StorePage.dlcs[23]);

            StorePage.games.Add(new Game("Witcher 2", 15, StorePage.publishers[3], new DateTime(2008, 05, 17)));
            StorePage.games[10].DLCs.Add(StorePage.dlcs[18]);
            StorePage.games[10].DLCs.Add(StorePage.dlcs[19]);
            StorePage.games[10].DLCs.Add(StorePage.dlcs[20]);
            StorePage.games[10].DLCs.Add(StorePage.dlcs[21]);
            StorePage.games[10].DLCs.Add(StorePage.dlcs[22]);
            StorePage.games[10].DLCs.Add(StorePage.dlcs[23]);

            StorePage.games.Add(new Game("Witcher 3", 40, StorePage.publishers[3], new DateTime(2015, 05, 17)));
            StorePage.games[11].DLCs.Add(StorePage.dlcs[18]);
            StorePage.games[11].DLCs.Add(StorePage.dlcs[19]);
            StorePage.games[11].DLCs.Add(StorePage.dlcs[20]);
            StorePage.games[11].DLCs.Add(StorePage.dlcs[21]);
            StorePage.games[11].DLCs.Add(StorePage.dlcs[22]);
            StorePage.games[11].DLCs.Add(StorePage.dlcs[23]);

            StorePage.publishers[3].Games.Add(StorePage.games[9]);
            StorePage.publishers[3].Games.Add(StorePage.games[10]);
            StorePage.publishers[3].Games.Add(StorePage.games[11]);

            StorePage.games.Add(new Game("GTA 5", 40, StorePage.publishers[4], new DateTime(2013, 11, 11)));
            StorePage.games[12].DLCs.Add(StorePage.dlcs[24]);
            StorePage.games[12].DLCs.Add(StorePage.dlcs[25]);
            StorePage.games[12].DLCs.Add(StorePage.dlcs[26]);


            StorePage.games.Add(new Game("Red Dead Redemption", 50, StorePage.publishers[4], new DateTime(2019, 01, 11)));
            StorePage.games[13].DLCs.Add(StorePage.dlcs[24]);
            StorePage.games[13].DLCs.Add(StorePage.dlcs[25]);
            StorePage.games[13].DLCs.Add(StorePage.dlcs[26]);

            StorePage.games.Add(new Game("GTA Vice City", 20, StorePage.publishers[4], new DateTime(2000, 03, 15)));
            StorePage.games[14].DLCs.Add(StorePage.dlcs[24]);
            StorePage.games[14].DLCs.Add(StorePage.dlcs[25]);
            StorePage.games[14].DLCs.Add(StorePage.dlcs[26]);

            StorePage.publishers[4].Games.Add(StorePage.games[12]);
            StorePage.publishers[4].Games.Add(StorePage.games[13]);
            StorePage.publishers[4].Games.Add(StorePage.games[14]);

            StorePage.games.Add(new Game("Final Fantasy XII", 30, StorePage.publishers[5], new DateTime(2012, 06, 18)));
            StorePage.games[15].DLCs.Add(StorePage.dlcs[27]);
            StorePage.games[15].DLCs.Add(StorePage.dlcs[28]);

            StorePage.games.Add(new Game("Final Fantasy XV", 45, StorePage.publishers[5], new DateTime(2015, 05, 16)));
            StorePage.games[16].DLCs.Add(StorePage.dlcs[29]);
            StorePage.games[16].DLCs.Add(StorePage.dlcs[30]);
            StorePage.games[16].DLCs.Add(StorePage.dlcs[31]);
            StorePage.games[16].DLCs.Add(StorePage.dlcs[32]);
            StorePage.games[16].DLCs.Add(StorePage.dlcs[33]);
            StorePage.games[16].DLCs.Add(StorePage.dlcs[34]);

            StorePage.games.Add(new Game("Final Fantasy XVI", 70, StorePage.publishers[5], new DateTime(2022, 04, 14)));
            StorePage.games[17].DLCs.Add(StorePage.dlcs[35]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[36]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[37]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[38]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[39]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[40]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[41]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[42]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[43]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[44]);
            StorePage.games[17].DLCs.Add(StorePage.dlcs[45]);

            StorePage.publishers[5].Games.Add(StorePage.games[15]);
            StorePage.publishers[5].Games.Add(StorePage.games[16]);
            StorePage.publishers[5].Games.Add(StorePage.games[17]);


            SetCurrentScreen(new StorePage(), "Store Page");
        }
        #endregion
    }
}
