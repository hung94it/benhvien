using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiabetesDido.ClassificationLogic
{
    interface ICreateClassificationModel
    {
        void createModel(ClassificationModel model, ClassificationData data);
    }
}
