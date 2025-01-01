# DroneOptimization
Yapay Öğrenme Temelleri Drone Tabanlı Deprem Sonrası İnsani Yardım Dağıtım Optimizasyonu
Proje Detayları:
1. İhtiyaç Noktaları ve Depolar:
o İhtiyaç Noktası Sayısı: Toplamda 40-50 arasında farklı ihtiyaç noktası.
o Depo Sayısı: 3 adet depo (Kuzey, Güney, Doğu bölgelerinde).
o Yardım Malzemeleri: Tıbbi malzeme ve yiyecek olmak üzere iki ana
yardım türü. (A-B) olarak isimlendirme yapabilirsiniz.
o Drone Kapasitesi: Her drone maksimum 30 birim yardım malzemesi
taşıyabilir (tıbbi veya yiyecek veya her ikiside).
2. Excel Dosyası Hazırlığı: Öğrencilerin aşağıdaki bilgileri içeren iki farklı Excel
dosyası hazırlamaları gerekmektedir:
o İhtiyaç Noktaları Mesafeleri Dosyası: İhtiyaç noktalarının birbirlerine ve
depolara olan uzaklıklarını (km cinsinden) içeren bir tablo.
o Yardım Talep Dosyası: Her ihtiyaç noktasının, her bir depodan kaç adet
tıbbi malzeme ve yiyecek talep ettiğini gösteren bir tablo
3. Kümeleme (Clustering): Öğrenciler, oluşturdukları mesafeler tablosunu
kullanarak ihtiyaç noktalarını aralarındaki mesafeler doğrultusunda kümeler
halinde gruplandıracaklardır. Bu işlemde kullanabilecekleri 5 farklı algoritma
aşağıda verilmiştir. Öğrenciler bu algoritmalardan birini seçip kullanabilir:
o Önerilen Kümeleme Algoritmaları:
▪ K-Means
▪ Elbow Method
▪ DBSCAN
▪ Agglomerative Clustering
▪ Gaussian Mixture Model
4. Rota Optimizasyonu: Her küme içerisindeki ihtiyaç noktaları arasında dağıtımı
en kısa sürede gerçekleştirmek için dronların izleyeceği en kısa yolu
planlamaları gerekmektedir. Bunun için aşağıdaki üç algoritmadan birini
kullanabilirler:
o Önerilen Rota Planlama Algoritmaları:
▪ Dijkstra Algoritması
▪ A* Algoritması
▪ Ant Colony Optimization (ACO)
5. Yükleme Stratejisi:
o Dronlar, toplamda 30 birim yardım malzemesi taşıyabilmektedir. Bir
ihtiyaç noktasının talep ettiği yardım malzemelerinin tamamı drona
sığmıyorsa, o ihtiyacın karşılanması sonraki drone ile sağlanacaktır.
o Drone tam kapasitesine ulaşmasa bile, taşıdığı malzemeler ilgili ihtiyaç
noktalarının talep ettiği yardımları kapsamalıdır.
