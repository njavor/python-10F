from django.shortcuts import render
from django.contrib.auth.decorators import login_required
from delesE.models import Profil

from delesU.models import Cikk

from .forms import UjEdCikkForm




#########  VIEW-k  #########


@login_required
def indexview_e(request):
    return render(request, 'indexE.html', {})

@login_required
def ujcikkview(request):
    if request.method == "POST":
        form = UjEdCikkForm(request.POST, request.FILES)
        if form.is_valid():
            form.save()
    else:
        form = UjEdCikkForm(request.POST or None)    
    return render(request, 'addCikkE.html', {"form": form})

@login_required
def sajatcikkview(request):
    aprofil = Profil.objects.get(user = request.user)
    context = {'kiadottak': Cikk.objects.filter(szerzo = aprofil.user.id)}
    return render(request, 'sajatcikkek.html', context)

@login_required
def levelezesview(request):
    context = {'poziciok':request.user, 'emberek': Profil.objects.all().exclude(user = request.user)}
    print(context)
    return render(request, 'levelezes.html', context)

@login_required
def profilview(request):
    context = {'en': Profil.objects.get(user = request.user)}
    print(context)
    return render(request, 'profilom.html', context)