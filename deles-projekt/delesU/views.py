from django.shortcuts import render
from django.views.generic import DetailView

from delesE.models import Profil
from .models import Cikk, Kategoria


#########  VIEW-k  #########
#!!! commoncontext = Kategoria.objects.all()


class CikkDetailView(DetailView):
    model = Cikk
    template_name = 'cikk.html'

    def get_context_data(self, *args, **kwargs):
        commoncontext = Kategoria.objects.all()
        context =  super(CikkDetailView, self).get_context_data(**kwargs)
        context['common'] = commoncontext
        return context


def indexview(request):
    context = {
        'common': Kategoria.objects.all(),
        'cikkek': Cikk.objects.order_by('-datum'),
        'kult': Cikk.objects.filter(kategoria__nev = "Kultúra").order_by('-datum'),
        'inter': Cikk.objects.filter(kategoria__nev = "Interjúk").order_by('-datum'),
        'diak': Cikk.objects.filter(kategoria__nev = "Diákélet").order_by('-datum'),
        }
    return render(request, 'index.html', context)

def kategoriaview(request, kat):
    context = {'common': Kategoria.objects.all(), 'kategoria_cikk': Cikk.objects.filter(kategoria__slug=kat)}
    return render(request, 'rovat.html', context)

def impresszumview (request):
    context = {
        'common': Kategoria.objects.all(),
        
        'szer': Profil.objects.filter(pozicio__nev='szerkesztő'),
        'olvszer': Profil.objects.filter(pozicio__nev='olvasószerkesztő'),
        'tordelo': Profil.objects.filter(pozicio__nev='tördelő'),
        'tanar': Profil.objects.filter(pozicio__nev='felügyelőtanár'),
    }
    return render(request, 'impresszum.html', context)