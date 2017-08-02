using PUBGSharp;
using PUBGSharp.Data;
using PUBGSharp.Exceptions;
using PUBGSharp.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PUBG_Player_Search
{
    public partial class Form1 : Form
    {
        public string apiKey;
        public int ModeIndex;
        public int RegionIndex;
        public int SeasonIndex;
        public string UserText;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SetStat("Rank", "");
            SetStat("Raiting", "");
            SetStat("LastKnownRankChange", "");
            SetStat("LastKnownRaitingChange", "");
            SetStat("LastPlacement", "");
            SetStat("LastKills", "");
            SetStat("LastAssists", "");
            SetStat("LastDamage", "");
            LoadSettings();
        }

        public async void RunStats()
        {
            if (UserBox.Text == "")
                return;

            var previousButtonText = RefreshButton.Text;
            RefreshButton.Enabled = false;
            RefreshButton.Text = "Loading...";
            SetStat("Rank", "");
            SetStat("Raiting", "");
            SetStat("LastKnownRankChange", "");
            SetStat("LastKnownRaitingChange", "");
            SetStat("LastPlacement", "");
            SetStat("LastKills", "");
            SetStat("LastAssists", "");
            SetStat("LastDamage", "");

            listView1.Items.Clear();

            using (var statsClient = new PUBGStatsClient(APIKeyBox.Text))
            {
                var player = await statsClient.GetPlayerStatsAsync(UserBox.Text);

                try
                {
                    var region = WhatRegion();
                    var mode = WhatMode();
                    var season = WhatSeason();
                    var masterLine = player.Stats.Find(x => x.Mode == mode && x.Region == region && x.Season == WhatSeason());
                    var KDR = masterLine.Stats.Find(x => x.Stat == Stats.KDR);
                    var WinPercentage = masterLine.Stats.Find(x => x.Stat == Stats.WinPercentage);
                    var TimeSurvived = masterLine.Stats.Find(x => x.Stat == Stats.TimeSurvived);
                    var RoundsPlayed = masterLine.Stats.Find(x => x.Stat == Stats.RoundsPlayed);
                    var WinTop10Ratio = masterLine.Stats.Find(x => x.Stat == Stats.WinTop10Ratio);
                    var Top10 = masterLine.Stats.Find(x => x.Stat == Stats.Top10);
                    var WeaponsAcquired = masterLine.Stats.Find(x => x.Stat == Stats.WeaponsAcquired);
                    var Top10Ratio = masterLine.Stats.Find(x => x.Stat == Stats.Top10Ratio);
                    var BestRating = masterLine.Stats.Find(x => x.Stat == Stats.BestRating);
                    var DamagePerGame = masterLine.Stats.Find(x => x.Stat == Stats.DamagePerGame);
                    var HeadshotKillsPerGame = masterLine.Stats.Find(x => x.Stat == Stats.HeadshotKillsPerGame);
                    var HealsPerGame = masterLine.Stats.Find(x => x.Stat == Stats.HealsPerGame);
                    var KillsPerGame = masterLine.Stats.Find(x => x.Stat == Stats.KillsPerGame);
                    var MoveDistancePerGame = masterLine.Stats.Find(x => x.Stat == Stats.MoveDistancePerGame);
                    var RevivesPerGame = masterLine.Stats.Find(x => x.Stat == Stats.RevivesPerGame);
                    var RoadKillsPerGame = masterLine.Stats.Find(x => x.Stat == Stats.RoadKillsPerGame);
                    var TeamKillsPerGame = masterLine.Stats.Find(x => x.Stat == Stats.TeamKillsPerGame);
                    var TimeSurvivedPerGame = masterLine.Stats.Find(x => x.Stat == Stats.TimeSurvivedPerGame);
                    var Top10sPerGame = masterLine.Stats.Find(x => x.Stat == Stats.Top10sPerGame);
                    var Top10Rate = masterLine.Stats.Find(x => x.Stat == Stats.Top10Rate);
                    var TeamKills = masterLine.Stats.Find(x => x.Stat == Stats.TeamKills);
                    var HeadshotKills = masterLine.Stats.Find(x => x.Stat == Stats.HeadshotKills);
                    var HeadshotKillRatio = masterLine.Stats.Find(x => x.Stat == Stats.HeadshotKillRatio);
                    var VehiclesDestroyed = masterLine.Stats.Find(x => x.Stat == Stats.VehiclesDestroyed);
                    var RoadKills = masterLine.Stats.Find(x => x.Stat == Stats.RoadKills);
                    var DailyKills = masterLine.Stats.Find(x => x.Stat == Stats.DailyKills);
                    var WeeklyKills = masterLine.Stats.Find(x => x.Stat == Stats.WeeklyKills);
                    var RoundMostKills = masterLine.Stats.Find(x => x.Stat == Stats.RoundMostKills);
                    var MaxKillStreaks = masterLine.Stats.Find(x => x.Stat == Stats.MaxKillStreaks);
                    var LongestTimeSurvived = masterLine.Stats.Find(x => x.Stat == Stats.LongestTimeSurvived);
                    var MostSurvivalTime = masterLine.Stats.Find(x => x.Stat == Stats.MostSurvivalTime);
                    var AverageSurvivalTime = masterLine.Stats.Find(x => x.Stat == Stats.AverageSurvivalTime);
                    var WinPoints = masterLine.Stats.Find(x => x.Stat == Stats.WinPoints);
                    var WalkDistance = masterLine.Stats.Find(x => x.Stat == Stats.WalkDistance);
                    var RideDistance = masterLine.Stats.Find(x => x.Stat == Stats.RideDistance);
                    var MoveDistance = masterLine.Stats.Find(x => x.Stat == Stats.MoveDistance);
                    var AverageWalkDistance = masterLine.Stats.Find(x => x.Stat == Stats.AverageWalkDistance);
                    var AverageRideDistance = masterLine.Stats.Find(x => x.Stat == Stats.AverageRideDistance);
                    var LongestKill = masterLine.Stats.Find(x => x.Stat == Stats.LongestKill);
                    var DamageDealt = masterLine.Stats.Find(x => x.Stat == Stats.DamageDealt);
                    var Knockouts = masterLine.Stats.Find(x => x.Stat == Stats.Knockouts);
                    var Wins = masterLine.Stats.Find(x => x.Stat == Stats.Wins);
                    var Losses = masterLine.Stats.Find(x => x.Stat == Stats.Losses);
                    var Raiting = masterLine.Stats.Find(x => x.Stat == Stats.Rating);
                    var Kills = masterLine.Stats.Find(x => x.Stat == Stats.Kills);
                    var Assists = masterLine.Stats.Find(x => x.Stat == Stats.Assists);
                    var Suicides = masterLine.Stats.Find(x => x.Stat == Stats.Suicides);
                    var Days = masterLine.Stats.Find(x => x.Stat == Stats.Days);
                    var Heals = masterLine.Stats.Find(x => x.Stat == Stats.Heals);
                    var Revives = masterLine.Stats.Find(x => x.Stat == Stats.Revives);
                    var Boosts = masterLine.Stats.Find(x => x.Stat == Stats.Boosts);
                    var DBNOs = masterLine.Stats.Find(x => x.Stat == Stats.DBNOs);
                    var PreviousGameRankChange = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).RatingRankChange;
                    var PreviousGameRaitingChange = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).RatingChange;
                    var PreviousGameKills = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).Kills;
                    var PreviousGameAssists = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).Assists;
                    var PreviousGamePlacement = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).Top10;
                    var PreviousGameDamage = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).Damage;
                    var PreviousGameWin = player.MatchHistory.Find(x => x.Mode == mode && x.Region == region).Wins;

                    if (PreviousGameRankChange < 0)
                    {
                        // Win
                        SetStat("LastKnownRankChange", "+" + (-PreviousGameRankChange).AddSeperators());
                        LastRankChange.ForeColor = Color.DarkGreen;
                    }
                    else if (PreviousGameRankChange > 0)
                    {
                        // Loss
                        SetStat("LastKnownRankChange", (-PreviousGameRankChange).AddSeperators());
                        LastRankChange.ForeColor = Color.Red;
                    }
                    else
                    {
                        // Didnt change
                        SetStat("LastKnownRankChange", "Did not change");
                        LastRankChange.ForeColor = Color.Black;
                    }

                    if (PreviousGameRaitingChange > 0)
                    {
                        // Win
                        SetStat("LastKnownRaitingChange", "+" + PreviousGameRaitingChange.AddSeperators());
                        LastRaitingChange.ForeColor = Color.DarkGreen;
                    }
                    else if (PreviousGameRaitingChange < 0)
                    {
                        // Loss
                        SetStat("LastKnownRaitingChange", PreviousGameRaitingChange.AddSeperators());
                        LastRaitingChange.ForeColor = Color.Red;
                    }
                    else
                    {
                        // Didnt change
                        SetStat("LastKnownRaitingChange", "Did not change");
                        LastRaitingChange.ForeColor = Color.Black;
                    }

                    var winString = "";

                    if (PreviousGameWin == 1)
                    {
                        winString = "Winner!";
                        LastPlacement.ForeColor = Color.DarkGreen;
                    }
                    else if (PreviousGameWin == 0 && PreviousGamePlacement == 1)
                    {
                        winString = "Top 10";
                        LastPlacement.ForeColor = Color.Blue;
                    }
                    else
                    {
                        winString = "Loss";
                        LastPlacement.ForeColor = Color.Red;
                    }

                    SetStat("Rank", "#" + Raiting.Rank.AddSeperators());
                    switch (Raiting.Rank)
                    {
                        case 1:
                            RankLabel.ForeColor = Color.Green;
                            RankLabel.Font = new Font("Arial", 13);
                            RankLabel.Location = new Point(56, 16);
                            break;
                        case 2:
                            RankLabel.ForeColor = Color.Green;
                            RankLabel.Font = new Font("Arial", 10);
                            RankLabel.Location = new Point(56, 18);
                            break;
                        case 3:
                            RankLabel.ForeColor = Color.Green;
                            RankLabel.Font = new Font("Arial", 9);
                            RankLabel.Location = new Point(56, 19);
                            break;
                        default:
                            RankLabel.ForeColor = Color.Black;
                            RankLabel.Font = new Font("Arial", 9);
                            RankLabel.Location = new Point(56, 19);
                            break;

                    }

                    SetStat("Raiting", Raiting.Value.AddSeperators());
                    SetStat("LastPlacement", winString);
                    SetStat("LastKills", PreviousGameKills);
                    SetStat("LastAssists", PreviousGameAssists);
                    SetStat("LastDamage", PreviousGameDamage);

                    AddItemToListView(RoundsPlayed);
                    AddItemToListView(Top10);
                    AddItemToListView(Wins);
                    AddItemToListView(Losses);
                    AddItemToListView(Raiting);
                    AddItemToListView(BestRating);
                    AddItemToListView(KDR);
                    AddItemToListView(Kills);
                    AddItemToListView(LongestKill);
                    AddItemToListView(Knockouts);
                    AddItemToListView(Assists);
                    AddItemToListView(Suicides);
                    AddItemToListView(Days);
                    AddItemToListView(Heals);
                    AddItemToListView(Revives);
                    AddItemToListView(Boosts);
                    AddItemToListView(WinPercentage);
                    AddItemToListView(TimeSurvived);
                    AddItemToListView(WinTop10Ratio);
                    AddItemToListView(WeaponsAcquired);
                    AddItemToListView(Top10Ratio);
                    AddItemToListView(DamagePerGame);
                    AddItemToListView(HeadshotKillsPerGame);
                    AddItemToListView(HealsPerGame);
                    AddItemToListView(KillsPerGame);
                    AddItemToListView(MoveDistancePerGame);
                    AddItemToListView(RevivesPerGame);
                    AddItemToListView(RoadKillsPerGame);
                    AddItemToListView(TeamKillsPerGame);
                    AddItemToListView(TimeSurvivedPerGame);
                    AddItemToListView(Top10sPerGame);
                    AddItemToListView(Top10Rate);
                    AddItemToListView(TeamKills);
                    AddItemToListView(HeadshotKills);
                    AddItemToListView(HeadshotKillRatio);
                    AddItemToListView(VehiclesDestroyed);
                    AddItemToListView(RoadKills);
                    AddItemToListView(DailyKills);
                    AddItemToListView(WeeklyKills);
                    AddItemToListView(RoundMostKills);
                    AddItemToListView(MaxKillStreaks);
                    AddItemToListView(LongestTimeSurvived);
                    AddItemToListView(MostSurvivalTime);
                    AddItemToListView(AverageSurvivalTime);
                    AddItemToListView(WinPoints);
                    AddItemToListView(WalkDistance);
                    AddItemToListView(RideDistance);
                    AddItemToListView(MoveDistance);
                    AddItemToListView(AverageWalkDistance);
                    AddItemToListView(AverageRideDistance);
                    AddItemToListView(DamageDealt);
                    AddItemToListView(DBNOs);
                }
                catch (PUBGSharpException ex) { }
                catch (NullReferenceException) { }

                RefreshButton.Enabled = true;
                RefreshButton.Text = previousButtonText;

                // Create a request for the URL. 		
                WebRequest request = WebRequest.Create($"https://pubgtracker.com/history/pc/{UserBox.Text}");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Cleanup the streams and the response.
                response.Close();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            RunStats();
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RunStats();
        }

        public void SetStat(string stat, object input)
        {
            var text = input.ToString();

            switch (stat)
            {
                case "Rank":
                    RankLabel.Text = text;
                    break;
                case "Raiting":
                    RaitingLabel.Text = text;
                    break;
                case "LastKnownRankChange":
                    LastRankChange.Text = text;
                    break;
                case "LastKnownRaitingChange":
                    LastRaitingChange.Text = text;
                    break;
                case "LastPlacement":
                    LastPlacement.Text = text;
                    break;
                case "LastKills":
                    LastKills.Text = text;
                    break;
                case "LastAssists":
                    LastAssists.Text = text;
                    break;
                case "LastDamage":
                    LastDamage.Text = text;
                    break;
                default:
                    break;
            }
        }

        public PUBGSharp.Data.Region WhatRegion()
        {
            switch (RegionBox.SelectedItem.ToString())
            {
                case "Oceania":
                    return PUBGSharp.Data.Region.OC;

                case "North Amercia":
                    return PUBGSharp.Data.Region.NA;

                case "South America":
                    return PUBGSharp.Data.Region.SA;

                case "Europe":
                    return PUBGSharp.Data.Region.EU;

                case "Asia":
                    return PUBGSharp.Data.Region.AS;

                case "South East Asia":
                    return PUBGSharp.Data.Region.SEA;

                case "All Regions Combined":
                    return PUBGSharp.Data.Region.AGG;

                default:
                    return PUBGSharp.Data.Region.NA;
            }
        }

        public Mode WhatMode()
        {
            switch (ModeBox.SelectedItem.ToString())
            {
                case "Solo":
                    return Mode.Solo;
                case "Duo":
                    return Mode.Duo;
                case "Squad":
                    return Mode.Squad;
                default:
                    return Mode.Solo;
            }
        }

        public string WhatSeason()
        {
            switch (SeasonBox.SelectedItem.ToString())
            {
                case "Season 1":
                    return Seasons.EASeason1;
                case "Season 2":
                    return Seasons.EASeason2;
                case "Season 3":
                    return Seasons.EASeason3;
                default:
                    return Seasons.EASeason3;
            }
        }

        public void AddItemToListView(object item1, object item2, object item3)
        {
            string[] row = { "", item1.ToString(), item2.ToString(), item3.ToString() };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        public void AddItemToListView(PUBGSharp.Net.Model.StatModel PUBGStat)
        {
            if (PUBGStat != null)
            {
                var name = "-";
                var value = "-";
                var rank = "-";

                if (PUBGStat.Stat.ToString() != string.Empty)
                    name = PUBGStat.Stat.ToString();

                if (PUBGStat.Value.ToString() != string.Empty)
                    value = PUBGStat.Value.AddSeperators();

                if (PUBGStat.Rank.ToString() != string.Empty)
                    rank = PUBGStat.Rank.AddSeperators();


                string[] row = { "", name, value, rank };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        public void LoadSettings()
        {
            this.Location = Properties.Settings.Default.Location;
            UserText = Properties.Settings.Default.User;
            ModeIndex = Properties.Settings.Default.Mode;
            RegionIndex = Properties.Settings.Default.Region;
            SeasonIndex = Properties.Settings.Default.Season;
            apiKey = Properties.Settings.Default.apikey;

            UserBox.Text = UserText;
            ModeBox.SelectedIndex = ModeIndex;
            RegionBox.SelectedIndex = RegionIndex;
            SeasonBox.SelectedIndex = SeasonIndex;
            APIKeyBox.Text = apiKey;
        }

        public void SaveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.User = UserBox.Text;
            Properties.Settings.Default.Mode = ModeBox.SelectedIndex;
            Properties.Settings.Default.Region = RegionBox.SelectedIndex;
            Properties.Settings.Default.Season = SeasonBox.SelectedIndex;
            Properties.Settings.Default.apikey = APIKeyBox.Text;
            Properties.Settings.Default.Save();
        }

        public void Form1_Move(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save();
        }

        private void jexireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "Jexire";
        }

        private void sponserADuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "SponserADuck";
        }

        private void fordeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "Fordey";
        }

        private void dopeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "Dopey";
        }

        private void firzenzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "Firzenzo";
        }

        private void broKnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBox.Text = "BroKn";
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (UserBox.Text != "")
                System.Diagnostics.Process.Start($"https://pubgtracker.com/profile/pc/{UserBox.Text}");
        }

        private void PlayerSearchGroup_Enter(object sender, EventArgs e)
        {

        }

        private void PlayerInformationGroup_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

    public static class ObjectExtension
    {
        public static string AddSeperators(this object input)
        {
            if (input.ToString().Contains("."))
            {
                string[] converted = input.ToString().Split(new char[] { '.' });

                if (converted[1].Length == 1)
                {
                    return Convert.ToDecimal(input).ToString("#,##0.0");
                }
                else
                {
                    return Convert.ToDecimal(input).ToString("#,##0.00");
                }
            }
            else
            {
                return Convert.ToDecimal(input).ToString("#,##0");
            }
        }
    }
}
