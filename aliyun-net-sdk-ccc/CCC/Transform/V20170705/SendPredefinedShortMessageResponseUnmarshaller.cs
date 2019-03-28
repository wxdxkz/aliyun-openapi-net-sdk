/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class SendPredefinedShortMessageResponseUnmarshaller
    {
        public static SendPredefinedShortMessageResponse Unmarshall(UnmarshallerContext context)
        {
			SendPredefinedShortMessageResponse sendPredefinedShortMessageResponse = new SendPredefinedShortMessageResponse();

			sendPredefinedShortMessageResponse.HttpResponse = context.HttpResponse;
			sendPredefinedShortMessageResponse.RequestId = context.StringValue("SendPredefinedShortMessage.RequestId");
			sendPredefinedShortMessageResponse.Success = context.BooleanValue("SendPredefinedShortMessage.Success");
			sendPredefinedShortMessageResponse.Code = context.StringValue("SendPredefinedShortMessage.Code");
			sendPredefinedShortMessageResponse.Message = context.StringValue("SendPredefinedShortMessage.Message");
			sendPredefinedShortMessageResponse.HttpStatusCode = context.IntegerValue("SendPredefinedShortMessage.HttpStatusCode");
			sendPredefinedShortMessageResponse.BizId = context.StringValue("SendPredefinedShortMessage.BizId");
        
			return sendPredefinedShortMessageResponse;
        }
    }
}