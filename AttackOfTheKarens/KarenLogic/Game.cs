using System.Collections.Generic;
using System.Windows.Forms;

namespace KarenLogic {
  public static class Game {
    public static float Score { get; set; }
    public static List<Form> openForms;

    static Game() {
      openForms = new List<Form>();
      //Score = 900f;
    }

    public static void AddToScore(float amount) {
      Score += amount;
    }
    public static void upgradePay(float amount)
    {
        Score -= amount;
    }
    public static void CloseAll() {
      for (int i = 0; i < openForms.Count; i++) {
        openForms[i].Close();
      }
    }
  }
}
