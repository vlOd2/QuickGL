@echo off
mkdir Bindgen
dotnet run --project QGLBindingsGen
dotnet build QuickGL
