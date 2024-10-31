from django.contrib import admin
from django.urls import path, include

from django.conf import settings
from django.conf.urls.static import static

from rest_framework import routers, serializers, viewsets

from delesU.views import indexview, CikkDetailView, impresszumview, kategoriaview
from delesE.views import indexview_e, levelezesview, profilview, ujcikkview, sajatcikkview

urlpatterns = [
    path('admin/', admin.site.urls),
    
    
    path('szerkesztoseg/', include('django.contrib.auth.urls')),
    path('szerkesztoseg/', indexview_e, name='szerkesztoseg'),
    path('szerkesztoseg/ujcikk/', ujcikkview, name="ujcikk"),
    path('szerkesztoseg/cikkeim/', sajatcikkview, name="sajatcikkek"),
    path('szerkesztoseg/levelezes/', levelezesview, name="levelezes"),
    path('szerkesztoseg/profilom/', profilview, name="profilom"),


    path('', indexview, name="home"),
    path('impresszum/', impresszumview, name="impresszum"),
    path('<slug:kat>/', kategoriaview, name='kategoria'),
    path('<slug:kat>/<str:pk>/', CikkDetailView.as_view(), name="cikk"),

    path('api-auth/', include('rest_framework.urls'))
] + static(settings.MEDIA_URL, document_root = settings.MEDIA_ROOT)