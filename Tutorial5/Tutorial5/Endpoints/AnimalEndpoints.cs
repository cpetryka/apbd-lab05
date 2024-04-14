using Tutorial5.Database;
using Tutorial5.Endpoints.dto;
using Tutorial5.Model;

namespace Tutorial5.Endpoints;

public static class AnimalEndpoints
{
    public static IRepository<Animal> AnimalRepository = new AnimalRepository();

    public static void MapAnimalEndpoints(this WebApplication app)
    {

        app.MapGet(
            "/animals",
            () => Results.Ok(new ResponseDto<List<Animal>>(AnimalRepository.GetAll())));

        app.MapGet("/animals/{id}", (int id) => {
            try {
                var animal = AnimalRepository.GetById(id);
                return Results.Ok(new ResponseDto<Animal>(animal));
            } catch (Exception e) {
                return Results.NotFound(new ResponseDto<Animal>(e.Message));
            }
        });

        app.MapPost(
            "/animals",
            (Animal animal) => Results.Created("", new ResponseDto<Animal>(AnimalRepository.Add(animal))));

        app.MapPut(
            "/animals/{id}",
            (int id, Animal animal) => {
                try {
                    return Results.Ok(new ResponseDto<Animal>(AnimalRepository.Update(id, animal)));
                } catch (Exception e) {
                    return Results.NotFound(new ResponseDto<Animal>(e.Message));
                }
            });

        app.MapDelete("/animals/{id}", (int id) => {
            try {
                var animal = AnimalRepository.Delete(id);
                return Results.Ok(new ResponseDto<Animal>(animal));
            } catch (Exception e) {
                return Results.NotFound(new ResponseDto<Animal>(e.Message));
            }
        });
    }
}