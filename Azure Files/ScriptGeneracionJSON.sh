echo hola >> myfile0.txt
echo hola >> miAPI.txt
for i in $(seq 1 6); do
  curl -X POST -u "apikey:lRl1dHI0z2Nnd_jxS_fWBs-YsT9-TFDcsoeDYg3HPnBp" \
  --header "Content-Type: audio/wav" \
  --data-binary @myfile$i.wav \
  "https://stream.watsonplatform.net/speech-to-text/api/v1/recognize">>myfile1.txt 
  dotnet run
  catmyfile0.txtmyfile$i.txt>myfile0.txt
  catmiAPI.txttextoPI.txt>miAPI.txt
done