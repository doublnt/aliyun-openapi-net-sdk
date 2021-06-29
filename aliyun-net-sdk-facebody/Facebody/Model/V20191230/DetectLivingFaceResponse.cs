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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class DetectLivingFaceResponse : AcsResponse
	{

		private string requestId;

		private DetectLivingFace_Data data;

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

		public DetectLivingFace_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DetectLivingFace_Data
		{

			private List<DetectLivingFace_Element> elements;

			public List<DetectLivingFace_Element> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class DetectLivingFace_Element
			{

				private string taskId;

				private string imageURL;

				private List<DetectLivingFace_Result> results;

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string ImageURL
				{
					get
					{
						return imageURL;
					}
					set	
					{
						imageURL = value;
					}
				}

				public List<DetectLivingFace_Result> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class DetectLivingFace_Result
				{

					private string label;

					private string suggestion;

					private float? rate;

					private List<DetectLivingFace_Frame> frames;

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public List<DetectLivingFace_Frame> Frames
					{
						get
						{
							return frames;
						}
						set	
						{
							frames = value;
						}
					}

					public class DetectLivingFace_Frame
					{

						private float? rate;

						private string url;

						public float? Rate
						{
							get
							{
								return rate;
							}
							set	
							{
								rate = value;
							}
						}

						public string Url
						{
							get
							{
								return url;
							}
							set	
							{
								url = value;
							}
						}
					}
				}
			}
		}
	}
}
