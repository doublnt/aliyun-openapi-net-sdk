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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DeleteTranscodeTemplateGroupResponseUnmarshaller
    {
        public static DeleteTranscodeTemplateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteTranscodeTemplateGroupResponse deleteTranscodeTemplateGroupResponse = new DeleteTranscodeTemplateGroupResponse();

			deleteTranscodeTemplateGroupResponse.HttpResponse = context.HttpResponse;
			deleteTranscodeTemplateGroupResponse.RequestId = context.StringValue("DeleteTranscodeTemplateGroup.RequestId");

			List<string> deleteTranscodeTemplateGroupResponse_nonExistTranscodeTemplateIds = new List<string>();
			for (int i = 0; i < context.Length("DeleteTranscodeTemplateGroup.NonExistTranscodeTemplateIds.Length"); i++) {
				deleteTranscodeTemplateGroupResponse_nonExistTranscodeTemplateIds.Add(context.StringValue("DeleteTranscodeTemplateGroup.NonExistTranscodeTemplateIds["+ i +"]"));
			}
			deleteTranscodeTemplateGroupResponse.NonExistTranscodeTemplateIds = deleteTranscodeTemplateGroupResponse_nonExistTranscodeTemplateIds;
        
			return deleteTranscodeTemplateGroupResponse;
        }
    }
}