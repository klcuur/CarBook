using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands
{
	public class RemoveFeatureCommand:IRequest
	{
		public int Id { get; set; }
		public RemoveFeatureCommand(int id)
		{
			Id = id;
		}
	}
}
