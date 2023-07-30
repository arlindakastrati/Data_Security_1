# Permbledhje e shkurter e projekteve

<h3><b>Projekti1: BEAUFORT CIPHER</b></h3>
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
 
Per zhvillimin e ketij programi është përdorur gjuha programuese:
<ul>
  <li>C#</li>
 </ul>

<h3><b>Projekti2: Klient/Server autorizues me TCP/UDP</b></h3>
<b>Klienti</b> i ofron dy shërbime kryesore: krijimi i shfrytëzuesve dhe regjistrimi i shpenzimeve. Procesi i krijimit të shfrytëzuesve shkon duke dërguar të dhënat e shfrytëzuesit, si emri, mbiemri, llogaria dhe fjalëkalimi, serverit të autorizimit. Serveri i autorizimit verifikon dhe validon të dhënat, dhe kthen një përgjigje të përkatëse (OK ose ERROR) për të konfirmuar krijimin e shfrytëzuesit.

Procesi i qasjes (login) ndodh kur klienti dërgon llogarinë dhe fjalëkalimin e shfrytëzuesit ekzistues te serveri i autorizimit. Serveri i autorizimit kontrollon kredencialet dhe përgjigjet me një përgjigje të përkatëse (OK ose ERROR) për të treguar suksesin ose dështimin e qasjes.

Në rast të qasjes (login) me sukses, serveri i autorizimit kthen një JWT (JSON Web Token) ose një XML të nënshkruar me çelësin e vet privat. Ky token ose XML përmban faktet relevante rreth shfrytëzuesit, si ID dhe të dhënat e tij.

Klienti i merr tokenin ose XML nga serveri dhe vërteton nënshkrimin e tij duke përdorur çelësin publik të serverit të autorizimit. Nëse vërtetimi i nënshkrimit është i suksesshëm, klienti shfaq një pamje ku gjenden faktet rreth shfrytëzuesit, si emri, mbiemri, dhe llogaria e tij. Nëse vërtetimi i nënshkrimit dështon, klienti tregon një mesazh të gabimit për të njoftuar përdoruesin se ka ndodhur një problem në vërtetimin e nënshkrimit.

Në këtë mënyrë, klienti ofron një ndërfaqe të përdorueshme dhe të sigurtë për krijimin e shfrytëzuesve, regjistrimin e shpenzimeve, si dhe për të qasur dhe verifikuar të dhënat e shfrytëzuesve përmes një serveri të autorizimit. Kjo ndihmon në sigurimin e informacionit të privatësisë dhe parandalimin e hyrjes së paligjshme në llogaritë e shfrytëzuesve.

<b>Serveri</b> është i projektuar për të ruajtur të dhënat e shfrytëzuesve në mënyrë të sigurt, duke përdorur teknikat e salted hashing për ruajtjen e fjalëkalimeve. Të dhënat e shfrytëzuesve ruhen në bazën e të dhënave MYSQL, JSON ose XML, ofruar si opsione të mbajtjes së të dhënave.


Përveç informacionit standarde të shfrytëzuesve, serveri i autorizimit gjithashtu mbajtë të dhënat e shpenzimeve për secilin shfrytëzues. Këto të dhëna përfshijnë llojin e faturës, vitin, muajin dhe vlerën e faturës në euro. Kështu, shfrytëzuesit kanë një regjistër të shpenzimeve që mund të kontrollojnë dhe menaxhojnë sipas nevojave të tyre. Gjithashtu, serveri lejon përdoruesin të shtojë një atribut shtesë sipas dëshirës, për të përshtatur informacionin në mënyrë të personalizuar.

Një aspekt i rëndësishëm është siguria e të dhënave. Me përdorimin e teknikave të salted hashing, fjalëkalimet e shfrytëzuesve ruhen në një formë të hashuar, duke e bërë shumë vështirë për të zbuluar fjalëkalimet origjinale edhe nëse baza e të dhënave është kompromentuar. Kjo siguron një nivel të lartë të mbrojtjes së të dhënave të ndjeshme.

Serveri i autorizimit gjithashtu ka një çelës publik XML/X.509, i cili dihet paraprakisht nga të gjitha palët tjera. Ky çelës publik përdoret për të verifikuar dhe nënshkruar dërgimet e të dhënave të shfrytëzuesve dhe të dhënave të shpenzimeve, duke garantuar autenticitetin dhe integritetin e të dhënave. Ky aspekt është i rëndësishëm për të siguruar që vetëm palët e lejuara kanë qasje dhe mund të dërgojnë të dhënat në serverin e autorizimit.

Ky server i autorizimit është një zgjidhje e sigurtë dhe e efektshme për menaxhimin e të dhënave të shfrytëzuesve dhe të dhënave të shpenzimeve, duke ofruar një kombinim të denjë të funksionalitetit, performancës dhe sigurisë.



Të gjitha kërkesat që klienti i dërgon te serveri i autorizimit duhet të jenë të enkriptuara me CBC DES. 

Skema e mesazheve është:
<b>base64(IV+rsa(KEY)+des(MSG))</b>

ku IV dhe KEY gjenerohen rastësisht (duke thirrur crypto API për gjenerim të sigurt të vlerave random). Çelësi simetrik KEY duhet të enkriptohet me çelësin publik të serverit të autorizimit. Të 
gjitha përgjigjet e kthyera nga serveri duhet të jenë të enkriptuara me çelësin e njejtë (KEY) të formës base64(<IV'>+des(<MSG'>)) ku <IV'> është vlerë tjetër e rastit. Simboli + paraqet vargëzimin e bajtave.


Per zhvillimin e ketij programi është përdorur gjuha programuese:
<ul>
  <li>C#</li>
 </ul>

 <h3><b>Projekti3: Email me nenshkrim i cili verifikohet permes qelsit publik/privat</b></h3>





 
