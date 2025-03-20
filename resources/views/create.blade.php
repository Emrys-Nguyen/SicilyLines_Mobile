<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ajouter</title>
</head>
<body style="background-color: #255483;">
@extends ('template')


@section('welcome')
<div class="container mt-4">
        <h3 style="color:white;">Ajouter</h3>
        <div class="card p-4 bg-light mb-3 rounded-5" style="background-color: #d9d9d9;">

    <form action="{{route('ferry.store')}}" method="POST" enctype="multipart/form-data">
        @csrf
        <div class="col-md-6">
        <label class="form-label"style="color:#255483; font-weight: 700;">Nom du Ferry :</label>
            <label for="nom" class="form-label text-white">Entrez le nom</label>
            <input type="text" class="form-control @error('nom') is-invalid @enderror" name="nom" id="nom" placeholder=""  value="{{old('nom')}}">
            @error('nom')
            <div class="invalid-feedback">{{$message}}</div>
            @enderror
        </div>

        <div class="col-md-6">
        <label for="longueur" class="form-label" style="color:#255483; font-weight: 700;">Longueur :</label>
        <div class="input-group">
            <input type="number" class="form-control @error('longueur') is-invalid @enderror" name="longueur" id="longueur" placeholder="" value="{{old('longueur')}}">
            <span class="input-group-text" style="color:#255483; font-weight: 700;">mètres</span>
</div> 
            @error('longueur')
            <div class="invalid-feedback">{{$message}}</div>
            @enderror
        </div>

        <div class="col-md-6">
        <label for="largeur" class="form-label"style="color:#255483; font-weight: 700;">Largeur :</label>
        <div class="input-group">
            <input type="number" class="form-control @error('largeur') is-invalid @enderror" name="largeur" id="largeur" placeholder=" " value="{{old('largeur')}}"><span class="input-group-text"style="color:#255483; font-weight: 700;">mètres</span>
            </div> 
            @error('largeur')
            <div class="invalid-feedback">{{$message}}</div>
            @enderror
        </div>

        <div class="col-md-6">
        <label for="vitesse" class="form-label" style="color:#255483; font-weight: 700;">Vitesse :</label><div class="input-group">
            <input type="number" class="form-control @error('vitesse') is-invalid @enderror" name="vitesse" id="vitesse" placeholder=" " value="{{old('vitesse')}}">
            <span class="input-group-text"style="color:#255483; font-weight: 700;">noeuds</span>
</div> 
            @error('vitesse')
            <div class="invalid-feedback">{{$message}}</div>
            @enderror
        </div>

        <div class="col-md-6">
        <label class="form-label" style="color:#255483; font-weight: 700;">Photo :</label>
        
            <label for="photo" class="form-label text-white">Entrez une photo</label>
            <input type="file" class="form-control @error('photo') is-invalid @enderror" name="photo" id="photo" placeholder=" " value="{{old('photo')}}">
            
            @error('photo')
            <div class="invalid-feedback">{{$message}}</div>
            @enderror
        </div>

        <div class="control d-flex justify-content-end ">
            <button class="btn btn-primary me-2 rounded-5" style="background-color: #255483; color:#d9d9d9;  font-size: 25px; font-weight: 500;">Envoyer</button>
            <button type="button" class="btn btn-secondary rounded-5" style="background-color: #255483; color:#d9d9d9;  font-size: 25px; font-weight: 500;">Retour</button>
        </div>
    </div>
        
    </form>
    </div>
    
    
    @endsection
</body>


</html>
