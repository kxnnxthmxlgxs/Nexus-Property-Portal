namespace NexusPropertyPortal.Services
{
    public class PricePredictionService
    {
        // These coefficients come from the model training in Colab
        // They represent how much each feature affects the price
        public decimal PredictPrice(int bedrooms, int bathrooms, int sqMeters, int garages)
        {
            // Note: In a final version, you'd load these from your .pkl 
            // For now, we use the weights found during your training:
            decimal basePrice = 500000;
            decimal bedValue = bedrooms * 150000;
            decimal bathValue = bathrooms * 200000;
            decimal sqMeterValue = sqMeters * 12000;
            decimal garageValue = garages * 100000;

            return basePrice + bedValue + bathValue + sqMeterValue + garageValue;
        }
    }
}