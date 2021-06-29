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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class DescribeIndexTemplateResponse : AcsResponse
	{

		private string requestId;

		private DescribeIndexTemplate_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeIndexTemplate_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeIndexTemplate_Result
		{

			private string indexTemplate;

			private bool? dataStream;

			private int? priority;

			private string ilmPolicy;

			private List<string> indexPatterns;

			private DescribeIndexTemplate_Template template;

			public string IndexTemplate
			{
				get
				{
					return indexTemplate;
				}
				set	
				{
					indexTemplate = value;
				}
			}

			public bool? DataStream
			{
				get
				{
					return dataStream;
				}
				set	
				{
					dataStream = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string IlmPolicy
			{
				get
				{
					return ilmPolicy;
				}
				set	
				{
					ilmPolicy = value;
				}
			}

			public List<string> IndexPatterns
			{
				get
				{
					return indexPatterns;
				}
				set	
				{
					indexPatterns = value;
				}
			}

			public DescribeIndexTemplate_Template Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public class DescribeIndexTemplate_Template
			{

				private string settings;

				private string mappings;

				private string aliases;

				public string Settings
				{
					get
					{
						return settings;
					}
					set	
					{
						settings = value;
					}
				}

				public string Mappings
				{
					get
					{
						return mappings;
					}
					set	
					{
						mappings = value;
					}
				}

				public string Aliases
				{
					get
					{
						return aliases;
					}
					set	
					{
						aliases = value;
					}
				}
			}
		}
	}
}
