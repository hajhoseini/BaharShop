using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.HomePages.Sliders;
using BaharShop.Application.Features.HomePages.Sliders.Commands.Requests;
using Microsoft.AspNetCore.Hosting;

namespace BaharShop.Application.Features.HomePages.Sliders.Commands.RequestHandlers
{
    public class CreateSliderCommandHandler : IRequestHandler<CreateSliderCommand, ResultDTO>
	{
		private readonly IGenericRepository<Slider> _genericRepository;
        private readonly IHostingEnvironment _environment;

        public CreateSliderCommandHandler(IGenericRepository<Slider> genericRepository, 
                                            IHostingEnvironment environment)
		{
			_genericRepository = genericRepository;
            _environment = environment;
        }

        public async Task<ResultDTO> Handle(CreateSliderCommand request, CancellationToken cancellationToken)
        {
            Common.File file = new Common.File(_environment);
            var resultUpload = file.UploadFile(request.File);

            Slider slider = new Slider()
            {
                Link = request.Link,
                Src = resultUpload.FileNameAddress,
            };

            var result = await _genericRepository.Create(slider);
            return result;
        }
    }
}
