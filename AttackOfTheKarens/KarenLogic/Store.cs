using System;
namespace KarenLogic {
  public class Store {
    public Karen karen;
    public Boss boss;
    public StoreManager manager;
    public bool containsOwner;

    static int number(int min, int max)
    {
      Random random = new Random();
      return random.Next(min, max);
    }
    public Store(Karen karen, Boss boss) 
    {
        this.karen = karen;
        this.boss = boss;
        this.manager = manager;
        
    }


        public void ActivateTheKaren()
        {
            karen.Appear();
        }

    public void BossTime()
    {
      if(karen.IsPresent) karen.Dissapear();
      boss.Appear();
    }
        public void DeployManager()
        {
            manager.Appear();
        }

        public void OwnerWalksIn()
        {
            containsOwner = true;
        }

        public void ResetOwner()
        {
            containsOwner = false;
        }

        public void Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.Damage(1);
            }
        }

    public void BUpdate()
    {
      if (boss.IsPresent && containsOwner)
      {
        boss.Damage(1);
      }
    }
  }
}
