namespace KarenLogic {
  public class Store {
    public Karen karen;
    public StoreManager manager;
    private bool containsOwner;

    public Store(Karen karen) {
      this.karen = karen;
    }

    public void ActivateTheKaren() {
      karen.Appear();
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
  }
}
