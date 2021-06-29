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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeTagResourcesResponseUnmarshaller
    {
        public static DescribeTagResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagResourcesResponse describeTagResourcesResponse = new DescribeTagResourcesResponse();

			describeTagResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeTagResourcesResponse.RequestId = _ctx.StringValue("DescribeTagResources.RequestId");

			List<DescribeTagResourcesResponse.DescribeTagResources_TagResource> describeTagResourcesResponse_tagResources = new List<DescribeTagResourcesResponse.DescribeTagResources_TagResource>();
			for (int i = 0; i < _ctx.Length("DescribeTagResources.TagResources.Length"); i++) {
				DescribeTagResourcesResponse.DescribeTagResources_TagResource tagResource = new DescribeTagResourcesResponse.DescribeTagResources_TagResource();
				tagResource.ResourceId = _ctx.StringValue("DescribeTagResources.TagResources["+ i +"].ResourceId");

				List<DescribeTagResourcesResponse.DescribeTagResources_TagResource.DescribeTagResources_TagItem> tagResource_tag = new List<DescribeTagResourcesResponse.DescribeTagResources_TagResource.DescribeTagResources_TagItem>();
				for (int j = 0; j < _ctx.Length("DescribeTagResources.TagResources["+ i +"].Tag.Length"); j++) {
					DescribeTagResourcesResponse.DescribeTagResources_TagResource.DescribeTagResources_TagItem tagItem = new DescribeTagResourcesResponse.DescribeTagResources_TagResource.DescribeTagResources_TagItem();
					tagItem.Key = _ctx.StringValue("DescribeTagResources.TagResources["+ i +"].Tag["+ j +"].Key");
					tagItem._Value = _ctx.StringValue("DescribeTagResources.TagResources["+ i +"].Tag["+ j +"].Value");

					tagResource_tag.Add(tagItem);
				}
				tagResource.Tag = tagResource_tag;

				describeTagResourcesResponse_tagResources.Add(tagResource);
			}
			describeTagResourcesResponse.TagResources = describeTagResourcesResponse_tagResources;
        
			return describeTagResourcesResponse;
        }
    }
}
