﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands
{
	public class CreateFeatureCommand:IRequest
	{
		public int FeatureID {  get; set; }
		public string Name {  get; set; }
	}
}
