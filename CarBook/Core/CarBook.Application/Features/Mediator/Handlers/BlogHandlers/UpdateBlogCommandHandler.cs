﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogID);
            values.CreatedDate = request.CreatedDate;
            values.CategoryID = request.CategoryID;
            values.AuthorID = request.AuthorID;
            values.Title = request.Title;
            values.CoverImageUrl = request.CoverImageUrl;
            values.BlogID = request.BlogID;

            await _repository.UpdateAsync(values);
        }
    }
}
