/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProvisionedThroughputDescription Object
    /// </summary>  
    public class ProvisionedThroughputDescriptionUnmarshaller : IUnmarshaller<ProvisionedThroughputDescription, XmlUnmarshallerContext>, IUnmarshaller<ProvisionedThroughputDescription, JsonUnmarshallerContext>
    {
        ProvisionedThroughputDescription IUnmarshaller<ProvisionedThroughputDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public ProvisionedThroughputDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProvisionedThroughputDescription unmarshalledObject = new ProvisionedThroughputDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LastDecreaseDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastDecreaseDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastIncreaseDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastIncreaseDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfDecreasesToday", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfDecreasesToday = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadCapacityUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ReadCapacityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WriteCapacityUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.WriteCapacityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProvisionedThroughputDescriptionUnmarshaller _instance = new ProvisionedThroughputDescriptionUnmarshaller();        

        public static ProvisionedThroughputDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}