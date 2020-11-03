

namespace OOPPizza
{
    abstract class PizzaStore
    {
        public void OrderPizza(string name)
        {
            Pizza pizza;
            
            pizza = CreatePizza(name);
            pizza.PreparePizza();
            pizza.AddingToppingsPizza();
            pizza.AddingTypePizza();
        }
        protected abstract Pizza CreatePizza(string type);


    }
}
