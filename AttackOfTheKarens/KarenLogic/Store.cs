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
      if (number(1, 100) == 1)
      {
        this.karen = boss;
      }
      else
      {
        this.karen = karen;
      }
    }


        public void ActivateTheKaren()
        {
            karen.Appear();
        }

    public void BossTime()
    {
      karen.Appear();
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
      if (karen.IsPresent && containsOwner)
      {
        karen.Damage(1);
      }
    }
  }
}
