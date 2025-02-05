# Generated by Django 4.0.3 on 2022-05-12 09:33

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('delesU', '0012_alter_cikk_alkat1_alter_cikk_alkat2_and_more'),
    ]

    operations = [
        migrations.AlterField(
            model_name='cikk',
            name='alkat1',
            field=models.CharField(blank=True, choices=[('friss', 'Friss'), ('legfontosabb', 'Legfontosabb'), ('fontos', 'Fontos')], max_length=20, verbose_name='alkategória 1'),
        ),
        migrations.AlterField(
            model_name='cikk',
            name='alkat2',
            field=models.CharField(blank=True, choices=[('friss', 'Friss'), ('legfontosabb', 'Legfontosabb'), ('fontos', 'Fontos')], max_length=20, verbose_name='alkategória 2'),
        ),
        migrations.AlterField(
            model_name='cikk',
            name='alkat3',
            field=models.CharField(blank=True, choices=[('friss', 'Friss'), ('legfontosabb', 'Legfontosabb'), ('fontos', 'Fontos')], max_length=20, verbose_name='alkategória 3'),
        ),
    ]
