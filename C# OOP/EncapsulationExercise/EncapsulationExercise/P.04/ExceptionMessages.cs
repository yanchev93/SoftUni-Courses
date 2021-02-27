namespace P04.PizzaCalories
{
    public static class ExceptionMessages
    {
        public static string InvalidDough => "Invalid type of dough.";

        public static string InvalidWeight => "Dough weight should be in the range [1..200].";

        public static string InvalidTopping => "Cannot place {0} on top of your pizza.";

        public static string InvalidToppingWeight => "{0} weight should be in the range [1..50].";

        public static string InvalidPizzaName => "Pizza name should be between 1 and 15 symbols.";

        public static string InvalidRangeOfToppings => "Number of toppings should be in range [0..10].";
    }
}
