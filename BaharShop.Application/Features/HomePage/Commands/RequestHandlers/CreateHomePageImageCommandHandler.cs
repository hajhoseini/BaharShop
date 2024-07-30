using BaharShop.Application.Features.HomePage.Commands.Requests;
using BaharShop.Common;
using BaharShop.Domain.Entities.HomePage;
using BaharShop.Domain.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Hosting;

namespace BaharShop.Application.Features.HomePage.Commands.RequestHandlers
{
    public class CreateHomePageImageCommandHandler : IRequestHandler<CreateHomePageImageCommand, ResultDTO>
    {
        private readonly IGenericRepository<HomePageImage> _genericRepository;
        private readonly IHostingEnvironment _environment;

        public CreateHomePageImageCommandHandler(IGenericRepository<HomePageImage> genericRepository,
                                            IHostingEnvironment environment)
        {
            _genericRepository = genericRepository;
            _environment = environment;
        }

        public async Task<ResultDTO> Handle(CreateHomePageImageCommand request, CancellationToken cancellationToken)
        {
            Common.File file = new Common.File(_environment);
            var resultUpload = file.UploadFile(request.homePageImageDTO.File);

            HomePageImage homePageImage = new HomePageImage()
            {
                Link = request.homePageImageDTO.Link,
                Src = resultUpload.FileNameAddress,
                ImageLocation = request.homePageImageDTO.ImageLocation
            };

            var result = await _genericRepository.Create(homePageImage);
            return result;
        }
    }
}
