using Microsoft.ML;


namespace ClassificationOfIrisFlower
{
    public class IrisFlowerClassifier
    {public string Prediction(IrisData flower)
        {
            MLContext mlContext = new MLContext();
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<IrisData>("iris-data.txt", separatorChar: ',', hasHeader: true); ;
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label")
               .Append(mlContext.Transforms.Concatenate("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"))
               .AppendCacheCheckpoint(mlContext)
               .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(labelColumnName: "Label", featureColumnName: "Features"))
               .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));
            var model = pipeline.Fit(trainingDataView);
            var prediction = mlContext.Model.CreatePredictionEngine<IrisData, IrisPrediction>(model).Predict(flower);
             
            return prediction.PredictedLabels;
        }
    }
}
