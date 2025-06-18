import { setupGuard } from "./guard";
import { createRouter, createWebHistory } from 'vue-router';

const routes = [
  { path: '/', name: 'Portal', component: () => import('../views/Portal/Home.vue') },
  { path: '/author', name: 'AuthorAdmin', component: () => import('../views/AuthorAdmin/Home.vue') },
  { path: '/platform', name: 'PlatformAdmin', component: () => import('../views/PlatformAdmin/Home.vue') },
  { path: '/crawler', name: 'CrawlerAdmin', component: () => import('../views/CrawlerAdmin/Home.vue') },
];

const router = createRouter({ history: createWebHistory(), routes });

export default router;
setupGuard(router);
