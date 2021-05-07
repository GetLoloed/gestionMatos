-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 07 mai 2021 à 23:28
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 8.0.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionmatos`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Alerte_inter` ()  select t2.id_mat,
       t2.nom,
       c.nom,
       s.nom, 
       if(isnull((SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1)),t2.date_instal,(SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1))
           as dateDernInter,
        ADDDATE(if(isnull((SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1)),t2.date_instal,(SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1)),
        t2.mtbf) as Datelimite
from materiel t2
         LEFT JOIN intervention AS i ON t2.id_mat = i.id_mat
         LEFT JOIN site as s ON t2.id_site = s.id_site
         LEFT JOIN client as c ON t2.id_site = c.id_client
where
      t2.perime = false
and
      ADDDATE(if(isnull((SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1)),t2.date_instal,(SELECT intervention.dateInter FROM materiel as t1 LEFT JOIN intervention ON intervention.id_mat = t1.id_mat WHERE t1.id_mat=t2.id_mat order by intervention.dateInter desc limit 1)),
        t2.mtbf) < adddate(now(),15)

group by t2.id_mat$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInter` ()  select i.id_intervention,m.id_mat, i.dateInter, i.com, m.nom, t.nom as nomType, c.nom as nomClient, s.nom as nomSite, if(i.finie = 'True', 'oui', 'non') as intervenu
from intervention i 
    left join materiel m on i.id_mat = m.id_mat 
    left join client c on m.id_client = c.id_client 
    left join site s on m.id_site = s.id_site
left join typemateriel t on m.id_type = t.id_type
order by i.finie ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getMat` ()  select m.id_mat,
       m.nom,
       m.referenece,
       m.descr,
       m.date_instal,
       m.mtbf,
       if(isnull((SELECT intervention.dateInter
                  FROM materiel as t1
                           LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                  WHERE t1.id_mat = m.id_mat
                  order by intervention.dateInter desc
                  limit 1)), m.date_instal, (SELECT intervention.dateInter
                                             FROM materiel as m
                                                      LEFT JOIN intervention ON intervention.id_mat = m.id_mat
                                             WHERE m.id_mat = m.id_mat
                                             order by intervention.dateInter desc
                                             limit 1))
                                         as dateDernInter,
       ADDDATE(if(isnull((SELECT intervention.dateInter
                          FROM materiel as t1
                                   LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                          WHERE t1.id_mat = m.id_mat
                          order by intervention.dateInter desc
                          limit 1)), m.date_instal, (SELECT intervention.dateInter
                                                     FROM materiel as t1
                                                              LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                                                     WHERE t1.id_mat = m.id_mat
                                                     order by intervention.dateInter desc
                                                     limit 1)),
               m.mtbf)                   as Datelimite,
       if(perime = 'True', 'oui', 'non') as perimeON,
       t.nom                             as nomType,
       s.nom                             as nomSite,
       c.nom                             as nomClient
from materiel m
         left join typemateriel t on t.id_type = m.id_type
         left join site s on s.id_site = m.id_site
         left join client c on c.id_client = m.id_client
order by perimeON, nom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getnClientWnMat` (IN `pid_client` INT(11))  select c.nom as nomClient, materiel.nom as nomMateriel from materiel left join client c on materiel.id_client = c.id_client where c.id_client = pid_client$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `rechMat` (IN `p1` INT(11) UNSIGNED)  select m.id_mat,
       m.nom,
       m.referenece,
       m.descr,
       m.date_instal,
       m.mtbf,
       if(isnull((SELECT intervention.dateInter
                  FROM materiel as t1
                           LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                  WHERE t1.id_mat = m.id_mat
                  order by intervention.dateInter desc
                  limit 1)), m.date_instal, (SELECT intervention.dateInter
                                             FROM materiel as m
                                                      LEFT JOIN intervention ON intervention.id_mat = m.id_mat
                                             WHERE m.id_mat = m.id_mat
                                             order by intervention.dateInter desc
                                             limit 1))
                                         as dateDernInter,
       ADDDATE(if(isnull((SELECT intervention.dateInter
                          FROM materiel as t1
                                   LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                          WHERE t1.id_mat = m.id_mat
                          order by intervention.dateInter desc
                          limit 1)), m.date_instal, (SELECT intervention.dateInter
                                                     FROM materiel as t1
                                                              LEFT JOIN intervention ON intervention.id_mat = t1.id_mat
                                                     WHERE t1.id_mat = m.id_mat
                                                     order by intervention.dateInter desc
                                                     limit 1)),
               m.mtbf)                   as Datelimite,
       if(perime = 'True', 'oui', 'non') as perimeON,
       t.nom                             as nomType,
       s.nom                             as nomSite,
       c.nom                             as nomClient
from materiel m
         left join typemateriel t on t.id_type = m.id_type
         left join site s on s.id_site = m.id_site
         left join client c on c.id_client = m.id_client

WHERE m.id_mat LIKE @p1
order by perimeON, nom$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `id_client` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `adresse` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`id_client`, `nom`, `adresse`) VALUES
(2, 'Sleeve Concepts', 'a');

-- --------------------------------------------------------

--
-- Structure de la table `intervention`
--

CREATE TABLE `intervention` (
  `id_intervention` int(11) NOT NULL,
  `dateInter` date NOT NULL,
  `com` text DEFAULT NULL,
  `id_mat` int(11) NOT NULL,
  `finie` varchar(5) NOT NULL COMMENT 'Boolean pour savoir si l''intervention a été effectuée.'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `intervention`
--

INSERT INTO `intervention` (`id_intervention`, `dateInter`, `com`, `id_mat`, `finie`) VALUES
(8, '2021-05-12', 'a', 24, 'True'),
(9, '2021-05-07', 'azezea', 26, 'True'),
(10, '2021-05-29', 'iazeieaziaze', 26, 'True');

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

CREATE TABLE `materiel` (
  `id_mat` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `referenece` varchar(100) NOT NULL,
  `descr` text DEFAULT NULL,
  `date_instal` date DEFAULT NULL,
  `mtbf` int(11) DEFAULT NULL,
  `perime` varchar(5) NOT NULL,
  `id_type` int(11) NOT NULL,
  `id_site` int(11) NOT NULL,
  `id_client` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`id_mat`, `nom`, `referenece`, `descr`, `date_instal`, `mtbf`, `perime`, `id_type`, `id_site`, `id_client`) VALUES
(24, 'iiyama', 'GB2760HSU', 'Ecran 27 pouces', '2021-05-06', 11, 'True', 3, 2, 2),
(25, 'iiyama2', 'GB2760HS', 'Ecran 27 pouces', '2021-05-07', 14, 'True', 3, 2, 2),
(26, '0L1VI3R', 'P3N15', 'ezezaezaeazzezae', '2021-05-07', 10, 'False', 3, 2, 2),
(27, 'zea', 'zeazae', 'zezaeza', '2021-05-06', 11, 'False', 6, 1, 2),
(28, 'zaezea', 'zaezae', 'zaezae', '2021-05-07', 2, 'True', 4, 3, 2),
(29, 'zaezea', 'zaezae', 'zaezae', '2021-05-07', 2, 'False', 4, 3, 2),
(30, 'zezaeeza', 'zeaeazzea', 'a', '2021-05-07', 2, 'False', 4, 2, 2),
(31, 'moi', 'zeaeazzea', 'a', '2021-05-07', 2, 'False', 4, 2, 2),
(32, 'ezaeazeza', 'ezaezaeza', 'zae', '2021-05-07', 100, 'True', 3, 2, 2),
(33, 'ezaeazeza', 'ezaezaeza', 'zae', '2021-05-07', 100, 'True', 3, 2, 2),
(34, 'loicloic', 'lloic', 'ezazae', '2021-05-07', 10, 'False', 3, 1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `site`
--

CREATE TABLE `site` (
  `id_site` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `adresse` varchar(200) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `ville` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `site`
--

INSERT INTO `site` (`id_site`, `nom`, `adresse`, `cp`, `ville`) VALUES
(1, 'Mairie Marolles', '1 Avenue Charles de Gaulle', '91630', 'Marolles-en-Hurepoix'),
(2, 'Mairie Arpajon', '70 Grande Rue', '91290', 'Arpajon'),
(3, 'zeazezaezaeeza', '3 Rue du potager', '75017', 'zeazeazaezae'),
(5, 'zaeeza', 'zeaeza', 'ezazae', 'zaezea'),
(6, 'zeaeza', 'zeaez', 'zeaez', 'zaeeza');

-- --------------------------------------------------------

--
-- Structure de la table `typemateriel`
--

CREATE TABLE `typemateriel` (
  `id_type` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `typemateriel`
--

INSERT INTO `typemateriel` (`id_type`, `nom`) VALUES
(1, 'Ordinateur fixe'),
(2, 'Ordinateur portable'),
(3, 'Ecran'),
(4, 'Serveur'),
(5, 'Imprimante'),
(6, 'Scanner'),
(7, 'Lecteur Code Barre'),
(8, 'Camera (Ip ou non)'),
(9, 'Projecteur'),
(10, 'Routeur'),
(11, 'Cables');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `login` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `login`, `mdp`) VALUES
(1, 'admin', 'admin');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id_client`);

--
-- Index pour la table `intervention`
--
ALTER TABLE `intervention`
  ADD PRIMARY KEY (`id_intervention`),
  ADD KEY `Intervention_Materiel_AK` (`id_mat`) USING BTREE;

--
-- Index pour la table `materiel`
--
ALTER TABLE `materiel`
  ADD PRIMARY KEY (`id_mat`),
  ADD KEY `Materiel_TypeMateriel_FK` (`id_type`),
  ADD KEY `Materiel_Site0_FK` (`id_site`),
  ADD KEY `Materiel_Client1_FK` (`id_client`);

--
-- Index pour la table `site`
--
ALTER TABLE `site`
  ADD PRIMARY KEY (`id_site`);

--
-- Index pour la table `typemateriel`
--
ALTER TABLE `typemateriel`
  ADD PRIMARY KEY (`id_type`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `id_client` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `intervention`
--
ALTER TABLE `intervention`
  MODIFY `id_intervention` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `materiel`
--
ALTER TABLE `materiel`
  MODIFY `id_mat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT pour la table `site`
--
ALTER TABLE `site`
  MODIFY `id_site` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `typemateriel`
--
ALTER TABLE `typemateriel`
  MODIFY `id_type` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `intervention`
--
ALTER TABLE `intervention`
  ADD CONSTRAINT `Intervention_Materiel_FK` FOREIGN KEY (`id_mat`) REFERENCES `materiel` (`id_mat`);

--
-- Contraintes pour la table `materiel`
--
ALTER TABLE `materiel`
  ADD CONSTRAINT `Materiel_Client1_FK` FOREIGN KEY (`id_client`) REFERENCES `client` (`id_client`),
  ADD CONSTRAINT `Materiel_Site0_FK` FOREIGN KEY (`id_site`) REFERENCES `site` (`id_site`),
  ADD CONSTRAINT `Materiel_TypeMateriel_FK` FOREIGN KEY (`id_type`) REFERENCES `typemateriel` (`id_type`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
