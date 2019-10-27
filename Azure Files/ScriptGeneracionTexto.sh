curl -X POST -u "apikey:zamzdNh00ByyrGzHNHiYLunTQmjD4xfh3APQ4NZ4b1bo" \
--header "Content-Type: text/plain;charset=utf-8" \
--header "Accept: application/json" \
--data-binary @miAPI.txt \
"https://gateway.watsonplatform.net/personality-insights/api/v3/profile?version=2017-10-13&consumption_preferences=true&raw_scores=true">>Personalidad.txt