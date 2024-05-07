using SaveTheOcean.DTOs;
using SaveTheOcean.Persistence.Mapping;
using SaveTheOcean.Persistence.Utils;

namespace SaveTheOcean
{
    public partial class FormGame : Form
    {

        const string MsgHealed = "El animal tiene un grado de afectación del {0}%, ¡está curado! \n\nGanas {1} de experiencia\nExperiencia del jugador: {2}";
        const string MsgNotHealed = "El animal tiene un grado de afectación del {0}%, no lo has podido curar :( \n\n Pierdes 20 de experiencia\nExperiencia del jugador: -20";
        const string KG = " kg";
        const string MsgGoodbye = "¡Hasta la próxima!";

        const int MinGA = 30, LoseXP = 20, Zero = 0;

        private RescueDTO rescue;
        private AAnimal animalToRescue;
        private Player currentPlayer;

        public FormGame(Player player)
        {
            InitializeComponent();

            animalToRescue = Helper.GenerateRandomAnimal();
            rescue = new RescueDTO(animalToRescue.Species);
            currentPlayer = player;

            ChangeRescueText();
            ChangeAnimalText();
        }

        private void ChangeRescueText()
        {
            lblResc.Text = rescue.NRescue;
            lblDate.Text = rescue.Date.ToString();
            lblFam.Text = rescue.Species;
            lblGA.Text = rescue.GA.ToString();
            lblLoc.Text = rescue.Location;
        }

        private void ChangeAnimalText()
        {
            lblName.Text = animalToRescue.Name;
            lblAnimFam.Text = animalToRescue.SuperFamily;
            lblAnimSpec.Text = animalToRescue.Species;
            lblAnimWeight.Text = animalToRescue.Weight.ToString() + KG;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            rescue.GA = animalToRescue.ApplyTreatment(true, rescue.GA);
            if (rescue.GA < Zero) rescue.GA = Zero;
            ShowHealDataAndExit();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            rescue.GA = animalToRescue.ApplyTreatment(false, rescue.GA);
            if (rescue.GA < Zero) rescue.GA = Zero;
            ShowHealDataAndExit();
        }


        private void ShowHealDataAndExit()
        {

            if (rescue.GA <= MinGA)
            {
                //Animal Curado - Tiene menos de 30 de GA
                currentPlayer.XP += currentPlayer.RewardXP;
                MessageBox.Show(string.Format(MsgHealed, rescue.GA, currentPlayer.RewardXP, currentPlayer.XP), "Información de la cura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Animal no curado - Tiene más de 30 de GA
                MessageBox.Show(string.Format(MsgNotHealed, rescue.GA), "Información de la cura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentPlayer.XP -= LoseXP;
                
            }

            MessageBox.Show(MsgGoodbye);
            Helper.SavePlayerData(currentPlayer, rescue, animalToRescue);

            RescueDAO rescDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            rescDAO.InsertRescue(rescue);
            
            Application.Exit();
        }

    }
}