using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
	public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler()
        {
        }

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.BlogID);
			values.AuthorID = request.AuthorID;
			values.CreatedDate = request.CreatedDate;
			values.CoverImageUrl = request.CoverImageUrl;
			values.CategoryID = request.CategoryID;
			values.Title = request.Title;

			await _repository.UpdateAsync(values);
		}
	}
}
