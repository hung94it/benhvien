using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiabetesDido.ClassificationLogic
{
    enum LearningAlgorithm
    {
        ID3,
        C45,
        NaiveBayes,
    }

    abstract class ClassificationModelType
    {
        abstract public LearningAlgorithm getClassificationModelType();
    }
}
