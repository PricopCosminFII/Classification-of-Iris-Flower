using Microsoft.ML.Data;

namespace ClassificationOfIrisFlower
{
    internal class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels { get; set; }
    }
}
