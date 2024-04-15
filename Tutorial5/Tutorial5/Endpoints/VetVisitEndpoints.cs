using Microsoft.AspNetCore.Mvc;
using Tutorial5.Endpoints.dto;
using Tutorial5.Model;
using Tutorial5.Repository;
using Tutorial5.Repository.Impl;

namespace Tutorial5.Endpoints;

public static class VetVisitEndpoints
{
    private static VetVisitRepository _vetVisitRepository = new VetVisitRepository();

    public static void MapVetVisitEndpoints(this WebApplication app)
    {
        app.MapGet(
            "/vetVisits",
            () => Results.Ok(new ResponseDto<List<VetVisit>>(_vetVisitRepository.GetAll())));

        app.MapGet(
            "/vetVisits/animalId/{animalId}",
            (int animalId) =>
            {
                try
                {
                    return Results.Ok(new ResponseDto<List<VetVisit>>(_vetVisitRepository.GetByAnimalId(animalId)));
                } catch (Exception e) {
                    Console.WriteLine("ERROR animalId: " + animalId);
                    return Results.NotFound(new ResponseDto<List<VetVisit>>(e.Message));
                }
            });

        app.MapPost(
            "/vetVisits",
            (VetVisit vetVisit) => Results.Created("", new ResponseDto<VetVisit>(_vetVisitRepository.Add(vetVisit))));
    }
}