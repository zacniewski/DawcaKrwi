-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Czas generowania: 05 Lut 2017, 14:39
-- Wersja serwera: 10.1.19-MariaDB
-- Wersja PHP: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `krew`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pacjenci`
--

CREATE TABLE `pacjenci` (
  `ID` int(11) NOT NULL,
  `Imie` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `TypKrwi` varchar(7) COLLATE utf8_polish_ci NOT NULL,
  `RH` varchar(1) COLLATE utf8_polish_ci NOT NULL,
  `Telefon` bigint(20) NOT NULL,
  `Pesel` bigint(20) NOT NULL,
  `Adres` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Kod` varchar(9) COLLATE utf8_polish_ci NOT NULL,
  `Miasto` varchar(20) COLLATE utf8_polish_ci NOT NULL,
  `Wojewodztwo` varchar(40) COLLATE utf8_polish_ci NOT NULL,
  `email` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `hasło` varchar(30) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `pacjenci`
--

INSERT INTO `pacjenci` (`ID`, `Imie`, `Nazwisko`, `TypKrwi`, `RH`, `Telefon`, `Pesel`, `Adres`, `Kod`, `Miasto`, `Wojewodztwo`, `email`, `hasło`) VALUES
(1, 'Adam', 'Rudy', 'A', '+', 777888999, 90111806455, 'ul. Morska 216', '81-041', 'Gdynia', 'Pomorskie', 'a.rudy@wp.pl', 'qwerty'),
(2, 'Wiola', 'Martwa', 'B', '+', 661888454, 90111804455, 'ul. Morska 217', '81-041', 'Gdansk', 'Pomorskie', 'a.martwa@gmail.com', 'asdfg'),
(3, 'Piotr', 'Rzezba', 'AB', '-', 510448267, 91121004854, 'ul. Ziemia 29/16', '51-004', 'Olsztyn', 'Warmińsko-Mazurskie', 'p.rzezba@wp.pl', 'jgyyyr'),
(4, 'Michał', 'Banan', 'A', '+', 574124845, 90091415487, 'ul. Karpowskiego 72/16', '41-112', 'Krakow', 'Śląskie', 'm.banan@far.pl', 'rejarf123'),
(5, 'Pawel', 'Tramwaj', '0', '+', 877674567, 90971214989, 'ul. Wiejska 220', '81-041', 'Szczecin', 'Warmińsko-Mazurskie', 'p.tramwaj@wp.pl', 'kolo12'),
(6, 'Robert', 'Stenchy', '0', '-', 877998767, 67091814769, 'ul. Kopytko 18', '65-189', 'Szczecin', 'Warmińsko-Mazurskie', 'r.stenchy@onet.pl', 'kopytko12'),
(7, 'Marcin', 'Jagodzki', 'B', '+', 730898138, 90101704475, 'ul. Dolna 12', '45-112', 'Łódz', 'Łódzkie', 'm.jagodzki@gmail.com', 'jagoda12'),
(8, 'Alicja', 'Widmer', '0', '+', 510447551, 62121904122, 'ul. Sadowska 2', '02-021', 'Warszawa', 'Mazowieckie', 'a.widmer@o2.pl', 'kosiarz54'),
(9, 'Jola', 'Sandomierska', 'AB', '+', 510557551, 64111804222, 'ul. Fabryczna 14/11', '85-741', 'Bydgoszcz', 'Kujawsko-Pomorskie', 'j.sandomierska@wp.pl', '!!warp12'),
(10, 'Marcin', 'Wrona ', 'AB', '+', 517848654, 82090705748, 'ul. 1Maja 12', '45-004', 'Opole', 'Opolskie', 'm.wrona@wp.pl', '@1!wowia'),
(11, 'Weroniaka', 'Wrona ', 'B', '-', 517854254, 82110705548, 'ul. 1Maja 12', '45-004', 'Opole', 'Opolskie', 'w.wrona@wp.pl', '@1!kosa'),
(12, 'Tupak', 'Raper ', '0', '+', 730666888, 92120684878, 'ul. Gwarna 12', '50-014', 'Wrocław', 'Dolnośląskie', 't.raper@2p.pl', '@1!yolo'),
(13, 'Kamil', 'Poważny ', 'B', '-', 514775412, 72110705548, 'ul. Kościuszki 22/11', '14-524', 'Zielona Góra', 'Lubuskie', 'k.pwoazny@wp.pl', '@1!kowal'),
(14, 'Monika', 'Poważna', '0', '+', 720666888, 72120684878, 'ul. Kościuszki 22/11', '14-524', 'Zielona Góra', 'Lubuskie', 'm.powazna@o2.pl', '!#$$9921'),
(15, 'Marcin', 'Hebel', '0', '-', 881114248, 80111405487, 'ul. Podwala 17', '18-882', 'Zielona Góra', 'Lubuskie', 'm.hebel@wp.pl', '^%$$$**jaj'),
(16, 'Monika', 'Hebel', 'B', '+', 887114552, 80120684878, 'ul. Podwala 19', '18-882', 'Zielona Góra', 'Lubuskie', 'm.hebel@o2.pl', '!#$$978'),
(17, 'Artur', 'Zacny', 'B', '-', 548125487, 92111754880, 'Wolnośći 22/11', '85-112', 'Bydgoszcz', 'Kujawsko-Pomorskie', 'a.zacny@wp.pl', 'asidj1929@'),
(18, 'Jola', 'Lojalna', '0', '+', 554887112, 98051702244, 'ul. Mikołaja 17', '86-745', 'Bydgoszcz', 'Kujawsko-Pomorskie', 'j.lojalna@o2.pl', '!#$$@98721'),
(19, 'Mokołąj', 'Rej', 'AB', '-', 784124687, 99071508744, 'ul. Zbożowa 22/11', '30-787', 'Kraków', 'Małopolskie', 'm.rejy@gmail.pl', '1259%%adf'),
(20, 'Ola', 'Wolna', '0', '+', 554887172, 98051702244, 'ul. Prądnicka 86', '30-114', 'Kraków', 'Małopolskie', 'o.wolna@speed.net', 'fasandfurius89!'),
(21, 'Maciej', 'Koronka', '0', '-', 887115448, 52101878454, 'ul. Prądnicka 12', '30-114', 'Kraków', 'Małopolskie', 'm.koronka@speed.net', 'slowandold!#$'),
(22, 'Beata', 'Durke', 'AB', '+', 514778114, 52111407844, 'ul. Prądnicka 17', '30-114', 'Kraków', 'Małopolskie', 'b.durke@speed.net', 'oldandfast%%@@'),
(23, 'Mokołąj', 'Peja', 'AB', '-', 784124555, 780718087454, 'ul. Wspólna 17/8', '25-257', 'Kielce', 'Świętokrzyskie', 'm.peja@gmail.pl', '7217@91j'),
(24, 'Ola', 'Siekiera', 'AB', '+', 554887558, 72051745544, 'ul. Wspólna 17/8', '25-257', 'Kielce', 'Świętokrzyskie', 'o.siekiera@gmail.net', 'fkosak12'),
(25, 'Wojtek', 'Koronka', '0', '-', 711887444, 90111804686, 'ul. Solna 12', '25-114', 'Katowice', 'Świętokrzyskie', 'mw.koronka@speed.net', 'slowandold!1$'),
(26, 'Beata', 'Garbacz', 'AB', '+', 887114225, 90111804457, 'ul. Solna 12', '25-114', 'Katowice', 'Świętokrzyskie', 'b.grabarz@gmail.com', 'ksoa21#$'),
(27, 'Grzegorz', 'Ogolony', 'B', '+', 554114888, 92010784755, 'ul. Planty 82/16', '25-024', 'Katowice', 'Świętokrzyskie', 'g.ogolony@gmail.com', 'k121soa21#$'),
(28, 'Kamil', 'Błonka ', 'B', '-', 517854444, 94110705548, 'ul. Okrzei Stefana 12', '35-002', 'Rzeszów', 'Podkarpackie', 'k.błonkaa@wp.pl', '@^#!a'),
(29, 'Monika', 'Trojczok ', 'AB', '+', 714112445, 94040108874, 'ul. Łączna 17/8', '35-002', 'Rzeszów', 'Podkarpackie', 't.faka@2p.pl', '&A^GJjjia'),
(30, 'Rafał', 'Wałkowicz ', 'B', '-', 700888000, 58112248802, 'ul. Towarowa 12', '15-006', 'Białystok', 'Podlaskie', 'r.wałkowicz.pl', '@1!k12a'),
(31, 'Monika', 'Konkol', '0', '+', 555128765, 90010608774, 'Ogrodowa 17', '15-005', 'Białystok', 'Podlaskie', 'm.kokol@wp.pl', 'jsiaj12#$'),
(32, 'Klaudiusz', 'Szeniszewski', 'AB', '-', 760848200, 85120508745, 'ul. Wariata 12', '60-006', 'Poznań', 'Wielkopolskie', 'k.szenisz.pl', '@b$%rzyt@!ka'),
(33, 'Marek', 'Joahimiak', '0', '+', 801504680, 92010608774, 'Cegłowa 16', '60-005', 'Poznań', 'Wielkopolskie', 'm.joahol@wp.pl', 'jsiaj85#$'),
(34, 'Karol', 'Brodawka', 'AB', '+', 501484268, 98051406100, 'ul. Ćwiartki 12', '70-811', 'Szczecin', 'Zachodnio-Pomorskie    ', 'k.brodawwka@wp.pl', '$%^@@wp'),
(35, 'Marek', 'Potocki', '0', '+', 802504680, 90010607845, 'Pod Ogrodami 16', '70-005', 'Szczecin', 'Zachodnio-Pomorskie', 'm.potocki@wp.pl', 'aj123$');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownicy`
--

CREATE TABLE `uzytkownicy` (
  `id` int(11) NOT NULL,
  `user` text COLLATE utf8_polish_ci NOT NULL,
  `pass` text COLLATE utf8_polish_ci NOT NULL,
  `uprawnienia` int(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `uzytkownicy`
--

INSERT INTO `uzytkownicy` (`id`, `user`, `pass`, `uprawnienia`) VALUES
(1, 'Adam', 'qwerty', 0),
(2, 'Marek', 'asdfg', 1),
(3, 'Andrzej', 'asdfg', 0),
(4, 'Justyna', 'yuiop', 0),
(5, 'Jakub', 'ertyu', 1),
(6, 'Janusz', 'cvbnm', 0);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `pacjenci`
--
ALTER TABLE `pacjenci`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
--
-- AUTO_INCREMENT dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
