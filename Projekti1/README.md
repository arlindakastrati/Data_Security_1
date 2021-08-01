<b>BEAUFORT CIPHER</b><br>
Beaufort Cipher e krijuar nga Francis Beaufort është një shifrim zëvendësimi e ngjashme me Vigenere Cipher por me një mekanizem më të modifikuar.Zbatimi i tij më i famshëm ishte në një makinë shifrimi të bazuar në rotor(Hagelin M-209). Beaufort Cipher bazohet në sheshin Beaufort i cili është në thelb i njëjtë me një shesh Vigenere por në rend të kundërt duke filluar me shkronjën "Z" në rreshtin e parë,ku rreshti i parë dhe kolona e fundit shërbejnë për të njëjtin qëllim. 

Shembull, nëse doni te enkriptoni karakterin e nje teksti të thjeshtë "E" me celesin "L", hapat do të ishin:<br>
1.Gjeni kolonën me karakterin "E" në krye,<br>
2.Vazhdoni poshtë nëpër atë kolonë për të gjetur çelësin "L",<br>
3.Vazhdoni në skajin e majtë të tabeles për të gjetur shkronjën e tekstit të koduar ("H" në këtë rast).<br>

Beaufort Cipher është shifrim reciprok që nënkupton se algoritmi i enkriptimit dhe dekriptimit është i njëjtë.<br>

Beaufort Cipher mund të përshkruhet edhe në formën algjebrike:<br>
M=M1,M2,M3,... -karakteret e plaintextit<br>
C=C1,C2,C3,....,CN-karakteret e ciphertextit<br>
K=K1,K2,K3,....,KN-karakteret e celesit<br>

E-Enkriptimi i Beuafort Cipher<br>
Ci=Ek(Mi)=(Ki-Mi) mod 26<br>

D-Dekriptimi i Beaufort Cipher<br>
Mi=Dk(Ci)=(Ki-Ci) mod 26<br><br>

Ky program eshte zhvilluar nga studentët e vitit të dytë FIEK, drejtimi Inxhinieri Kompjuterike në lëndën Siguria e të Dhënave
<ul>
 <li> Arlinda Kastrati</li>
 <li> Alberiana Tofaj</li>
 <li>Ilir Jasharaj</li>
 </ul>
 
Per zhvillimin e ketij programi është përdorur gjuha programuese:
<ul>
  <li>C#</li>
 </ul>
