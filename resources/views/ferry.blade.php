<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Liste des Ferrys</title>
    @extends ('template')

@section('welcome')
</head>
<body style="background:#255483;">
    <div class="bg text-white ">
    <div class="container my-5 ">
        <div class="card border border-0">
            <div class="card-body bg text-white"style="background:#255483;">
                <h1>Ferrys</h1>
                <div class="row">
                    @foreach($ferrys as $ferry)
                        <div class="col-md-6 mb-3">
                            <div class="d-flex justify-content-between align-items-center bg-light text-dark p-3 rounded-pill">
                                <span class="text p-2" style="color:#255483;  font-size: 20px; " ><b>{{$ferry->nom}}</b></span>
                                <div>
                                    <button class="btn">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="35" height="35" fill="#255483" class="bi bi-eye-fill" viewBox="0 0 16 16">
  <path d="M10.5 8a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0"/>
  <path d="M0 8s3-5.5 8-5.5S16 8 16 8s-3 5.5-8 5.5S0 8 0 8m8 3.5a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7"/>
</svg>
                                    </button>
                                    <button class="btn ">
                                        <svg xmlns="http://www.w3.org/2000/svg" width="35" height="35" fill="#255483" class="bi bi-trash-fill" viewBox="0 0 16 16">
                                            <path d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5M8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5m3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0"/>
</svg></button>
                                </div>
                            </div>
                        </div>
                    @endforeach
                </div>
                <div class="d-flex justify-content-between mt-3">
                    <button class="btn btn-light rounded-pill ">
                    <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="#255483" class="bi bi-printer-fill" viewBox="0 0 16 16">
  <path d="M5 1a2 2 0 0 0-2 2v1h10V3a2 2 0 0 0-2-2zm6 8H5a1 1 0 0 0-1 1v3a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1v-3a1 1 0 0 0-1-1"/>
  <path d="M0 7a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v3a2 2 0 0 1-2 2h-1v-2a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2v2H2a2 2 0 0 1-2-2zm2.5 1a.5.5 0 1 0 0-1 .5.5 0 0 0 0 1"/>
</svg>
                    </button>
                    <div>
                        <button class="btn btn-light rounded-pill"style="color:#255483;  font-size: 25px; "><b><</b></button>
                        <button class="btn btn-light rounded-pill"style="color:#255483;  font-size: 25px; "><b>></b></button>
                    </div>
                    <a href="{{route('ferry.create')}}" class="btn btn-light rounded-pill "style="color:#255483;  font-size: 15px; "><b>Ajouter</b></a>
                </div>
            </div>
        </div>
    </div>
    </div>
    <style>


</style>
    @endsection
</body>
</html>
