using System;
namespace KarenLogic {
  public class Store {
    public Karen karen;
    public  Boss boss;
    public StoreManager manager;
    private bool containsOwner;

    static int number(int min, int max)
    {
      Random random = new Random();
      return random.Next(min, max);
    }
    public Store(Karen karen, Boss boss) 
    {
      this.karen = karen;
      this.boss = boss;
    }

    public void ActivateTheKaren() {
      karen.Appear();
    }

    public void BossTime()
    {
      boss.Appear();
    }

    public void OwnerWalksIn() {
      containsOwner = true;
    }

    public void ResetOwner() {
      containsOwner = false;
    }

    public void Update() {
      if (karen.IsPresent && containsOwner) {
        karen.Damage(1);
      }
    }

    public void BUpdate()
    {
      if (karen.IsPresent && containsOwner)
      {
        boss.Damage(1);
      }
    }
  }
}
