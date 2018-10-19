
namespace DesignPattern.Proxy
{
  public class VueVehicule
  {
    public void LoadProxy() {
      Animation animation = new AnimationProxy();
      animation.dessine();
      animation.clic();
      animation.dessine();
    }
  }
}