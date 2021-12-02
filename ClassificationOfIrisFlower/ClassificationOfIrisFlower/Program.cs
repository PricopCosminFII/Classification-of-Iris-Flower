
using ClassificationOfIrisFlower;

IrisData flower=new IrisData()
{
    SepalLength = 5.4f,
    SepalWidth = 3.5f,
    PetalLength = 1.2f,
    PetalWidth = 0.4f,
};
IrisFlowerClassifier classifier = new IrisFlowerClassifier();
Console.WriteLine(classifier.Prediction(flower));