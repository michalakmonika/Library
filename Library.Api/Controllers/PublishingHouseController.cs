using Library.Api.Models;
using Library.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishingHouseController : ControllerBase
    {
        private readonly IPublishingHouseService _publishingHouseService;

        public PublishingHouseController(IPublishingHouseService publishingHouseService) 
        {
            _publishingHouseService = publishingHouseService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var publishingHouses = _publishingHouseService.GetAll();

            return Ok(publishingHouses);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            var publishingHouse = _publishingHouseService.GetById(id);

            return Ok(publishingHouse);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateAndUpdatePublishingHouseDto dto)
        {
            var id = _publishingHouseService.Create(dto);

            return Created($"/api/publishingHouse/{id}", null);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] CreateAndUpdatePublishingHouseDto dto)
        {
            _publishingHouseService.Update(id, dto);

            return Ok();
        }
    }
}