-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 04 2024 г., 13:24
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `triod_db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `device_type`
--

CREATE TABLE `device_type` (
  `device_type_id` int(11) NOT NULL,
  `device_type_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `device_type`
--

INSERT INTO `device_type` (`device_type_id`, `device_type_name`) VALUES
(1, 'Мобильный телефон'),
(2, 'Фотоаппарат'),
(3, 'Холодильник'),
(4, 'Стиральная машина'),
(5, 'Микроволновка'),
(6, 'Телевизор');

-- --------------------------------------------------------

--
-- Структура таблицы `masters`
--

CREATE TABLE `masters` (
  `master_id` int(11) NOT NULL,
  `master_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `masters`
--

INSERT INTO `masters` (`master_id`, `master_name`) VALUES
(1, 'Аксенов Т.А.'),
(2, 'Аблаев Р.А.');

-- --------------------------------------------------------

--
-- Структура таблицы `requests`
--

CREATE TABLE `requests` (
  `request_id` int(11) NOT NULL,
  `request_acc_date` datetime NOT NULL,
  `device_type_id` int(11) DEFAULT NULL,
  `device_fabricator` varchar(30) DEFAULT NULL,
  `device_model` varchar(50) DEFAULT NULL,
  `device_serial_num` varchar(12) DEFAULT NULL,
  `client_name` varchar(50) DEFAULT NULL,
  `client_address` text DEFAULT NULL,
  `client_phone` varchar(11) DEFAULT NULL,
  `request_status_id` int(11) NOT NULL,
  `master_id` int(11) DEFAULT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `requests`
--

INSERT INTO `requests` (`request_id`, `request_acc_date`, `device_type_id`, `device_fabricator`, `device_model`, `device_serial_num`, `client_name`, `client_address`, `client_phone`, `request_status_id`, `master_id`, `user_id`) VALUES
(17, '2024-06-02 21:07:47', 2, 'Шлюха Корпорэйшен', 'Голая', '28 лет', 'Валуев', '', '', 1, 2, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `request_status`
--

CREATE TABLE `request_status` (
  `request_status_id` int(11) NOT NULL,
  `request_status_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `request_status`
--

INSERT INTO `request_status` (`request_status_id`, `request_status_name`) VALUES
(1, 'Принят'),
(2, 'На согласовании'),
(3, 'Ожидание запчастей'),
(4, 'В ремонте'),
(5, 'Готово'),
(6, 'Выданные'),
(7, 'Без ремонта'),
(8, 'Заявка'),
(9, 'Сделано на месте');

-- --------------------------------------------------------

--
-- Структура таблицы `stock_records`
--

CREATE TABLE `stock_records` (
  `stock_record_id` int(11) NOT NULL,
  `stock_record_date` datetime NOT NULL,
  `stock_record_sum` int(11) NOT NULL,
  `stock_record_purpose_id` int(11) NOT NULL,
  `stock_record_operation_id` int(11) NOT NULL,
  `stock_record_note` text DEFAULT NULL,
  `request_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `stock_records`
--

INSERT INTO `stock_records` (`stock_record_id`, `stock_record_date`, `stock_record_sum`, `stock_record_purpose_id`, `stock_record_operation_id`, `stock_record_note`, `request_id`) VALUES
(15, '2024-06-02 14:03:58', 2000, 1, 1, 'От Валуева. Предоплата на запчасти', NULL),
(16, '2024-06-02 14:03:58', 5000, 2, 2, 'Толе за ремонт', NULL),
(28, '2024-06-02 15:04:08', 400, 1, 2, 'Толя купил запчасти для huesos ', NULL),
(33, '2024-06-02 21:08:04', 250, 1, 1, '', 17),
(34, '2024-06-02 22:19:30', 5000, 3, 1, 'Оплатили заранее', 17),
(35, '2024-06-02 22:19:57', 100, 3, 1, 'Заказали на корпоратив', 17);

-- --------------------------------------------------------

--
-- Структура таблицы `stock_record_operation`
--

CREATE TABLE `stock_record_operation` (
  `stock_record_operation_id` int(11) NOT NULL,
  `stock_record_operation_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `stock_record_operation`
--

INSERT INTO `stock_record_operation` (`stock_record_operation_id`, `stock_record_operation_name`) VALUES
(1, 'Приход'),
(2, 'Расход');

-- --------------------------------------------------------

--
-- Структура таблицы `stock_record_purpose`
--

CREATE TABLE `stock_record_purpose` (
  `stock_record_purpose_id` int(11) NOT NULL,
  `stock_record_purpose_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `stock_record_purpose`
--

INSERT INTO `stock_record_purpose` (`stock_record_purpose_id`, `stock_record_purpose_name`) VALUES
(1, 'Запчасти'),
(2, 'Зарплата'),
(3, 'Предоплата');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_login` varchar(20) NOT NULL,
  `user_password` text NOT NULL,
  `user_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`user_id`, `user_login`, `user_password`, `user_name`) VALUES
(5, 'AblaevRA', '$2a$11$fDS1LN/hYSEkmEZ4OL156O6AwDYXjX1I3sczWUoimzed77cVwtkBe', 'Аблаев Р.А.'),
(8, 'DavalovaAV', '$2a$11$StX1n75/yESBX.VN/TVyvOE9uLqzXBq6kDVqqepfiRYVWaS1Ffp9C', 'Давалова А.В.');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `device_type`
--
ALTER TABLE `device_type`
  ADD PRIMARY KEY (`device_type_id`);

--
-- Индексы таблицы `masters`
--
ALTER TABLE `masters`
  ADD PRIMARY KEY (`master_id`);

--
-- Индексы таблицы `requests`
--
ALTER TABLE `requests`
  ADD PRIMARY KEY (`request_id`),
  ADD KEY `device_type_id` (`device_type_id`,`request_status_id`,`master_id`),
  ADD KEY `request_status_id` (`request_status_id`),
  ADD KEY `master_id` (`master_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Индексы таблицы `request_status`
--
ALTER TABLE `request_status`
  ADD PRIMARY KEY (`request_status_id`);

--
-- Индексы таблицы `stock_records`
--
ALTER TABLE `stock_records`
  ADD PRIMARY KEY (`stock_record_id`),
  ADD KEY `stock_record_purpose_id` (`stock_record_purpose_id`,`stock_record_operation_id`,`request_id`),
  ADD KEY `stock_record_operation_id` (`stock_record_operation_id`),
  ADD KEY `request_id` (`request_id`);

--
-- Индексы таблицы `stock_record_operation`
--
ALTER TABLE `stock_record_operation`
  ADD PRIMARY KEY (`stock_record_operation_id`);

--
-- Индексы таблицы `stock_record_purpose`
--
ALTER TABLE `stock_record_purpose`
  ADD PRIMARY KEY (`stock_record_purpose_id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `device_type`
--
ALTER TABLE `device_type`
  MODIFY `device_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `masters`
--
ALTER TABLE `masters`
  MODIFY `master_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `requests`
--
ALTER TABLE `requests`
  MODIFY `request_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `request_status`
--
ALTER TABLE `request_status`
  MODIFY `request_status_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `stock_records`
--
ALTER TABLE `stock_records`
  MODIFY `stock_record_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT для таблицы `stock_record_operation`
--
ALTER TABLE `stock_record_operation`
  MODIFY `stock_record_operation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `stock_record_purpose`
--
ALTER TABLE `stock_record_purpose`
  MODIFY `stock_record_purpose_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `requests`
--
ALTER TABLE `requests`
  ADD CONSTRAINT `requests_ibfk_1` FOREIGN KEY (`device_type_id`) REFERENCES `device_type` (`device_type_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `requests_ibfk_2` FOREIGN KEY (`request_status_id`) REFERENCES `request_status` (`request_status_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `requests_ibfk_3` FOREIGN KEY (`master_id`) REFERENCES `masters` (`master_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `requests_ibfk_4` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `stock_records`
--
ALTER TABLE `stock_records`
  ADD CONSTRAINT `stock_records_ibfk_1` FOREIGN KEY (`stock_record_operation_id`) REFERENCES `stock_record_operation` (`stock_record_operation_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `stock_records_ibfk_2` FOREIGN KEY (`stock_record_purpose_id`) REFERENCES `stock_record_purpose` (`stock_record_purpose_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `stock_records_ibfk_3` FOREIGN KEY (`request_id`) REFERENCES `requests` (`request_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
